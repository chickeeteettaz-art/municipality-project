using muni_class_library;
using System.Net.Http.Json;
using System.Text.Json;


namespace municipality_app.Services
{
    public class IssueStorageService
    {
        private readonly HttpClient _httpClient;

        private const string ApiUrl =
            "https://localhost:7299/api/issues";

        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        public IssueStorageService()
        {
            _httpClient = new HttpClient();

            // Optional timeout
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }


        // =========================================================
        // GET ALL ISSUES
        // GET: https://localhost:7299/api/issues
        // =========================================================

        public async Task<List<IssueEntity>> GetIssuesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();

                    throw new Exception(
                        $"Failed to retrieve issues. " +
                        $"Status: {(int)response.StatusCode} " +
                        $"{response.ReasonPhrase}\n{error}");
                }

                List<IssueEntity>? issues = await response.Content.ReadFromJsonAsync<List<IssueEntity>>(_jsonOptions);

                return issues ?? new List<IssueEntity>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(
                    "Unable to connect to the Issues API.\n\n" +
                    "Make sure the API is running at:\n" +
                    ApiUrl,
                    ex);
            }
        }


        // =========================================================
        // GET SINGLE ISSUE
        // GET: /api/issues/{partitionKey}/{rowKey}
        // =========================================================

        public async Task<IssueEntity?> GetIssueAsync(string partitionKey, string rowKey)
        {
            try
            {
                string url =
                    $"{ApiUrl}/{Uri.EscapeDataString(partitionKey)}/" +
                    $"{Uri.EscapeDataString(rowKey)}";

                HttpResponseMessage response =
                    await _httpClient.GetAsync(url);

                if (response.StatusCode ==
                    System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();

                    throw new Exception(
                        $"Failed to retrieve issue. " +
                        $"Status: {(int)response.StatusCode} " +
                        $"{response.ReasonPhrase}\n{error}");
                }

                return await response.Content
                    .ReadFromJsonAsync<IssueEntity>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(
                    "Unable to connect to the Issues API.",
                    ex);
            }
        }


        // =========================================================
        // CREATE ISSUE
        // POST: /api/issues
        // =========================================================

        public async Task<IssueEntity> CreateIssueAsync(IssueEntity issue)
        {
            try
            {
                issue.PartitionKey = "issues";
                issue.RowKey = Guid.NewGuid().ToString();
                HttpResponseMessage response =
                    await _httpClient.PostAsJsonAsync(ApiUrl, issue,_jsonOptions);

                if (!response.IsSuccessStatusCode)
                {
                    string error =
                        await response.Content.ReadAsStringAsync();

                    throw new Exception(
                        $"Failed to create issue. " +
                        $"Status: {(int)response.StatusCode} " +
                        $"{response.ReasonPhrase}\n{error}");
                }

                IssueEntity? createdIssue =
                    await response.Content
                        .ReadFromJsonAsync<IssueEntity>(_jsonOptions);

                if (createdIssue == null)
                {
                    throw new Exception(
                        "The API returned an empty issue response.");
                }

                return createdIssue;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(
                    "Unable to connect to the Issues API.",
                    ex);
            }
        }


        // =========================================================
        // UPDATE ISSUE
        // PUT: /api/issues/{partitionKey}/{rowKey}
        // =========================================================

        public async Task<IssueEntity> UpdateIssueAsync(IssueEntity issue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(issue.PartitionKey))
                {
                    throw new ArgumentException(
                        "Issue PartitionKey is required.");
                }

                if (string.IsNullOrWhiteSpace(issue.RowKey))
                {
                    throw new ArgumentException(
                        "Issue RowKey is required.");
                }

                string url =
                    $"{ApiUrl}/" +
                    $"{Uri.EscapeDataString(issue.PartitionKey)}/" +
                    $"{Uri.EscapeDataString(issue.RowKey)}";

                HttpResponseMessage response =
                    await _httpClient.PutAsJsonAsync(
                        url,
                        issue,
                        _jsonOptions);

                if (response.StatusCode ==
                    System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception(
                        "The issue could not be found.");
                }

                if (!response.IsSuccessStatusCode)
                {
                    string error =
                        await response.Content.ReadAsStringAsync();

                    throw new Exception(
                        $"Failed to update issue. " +
                        $"Status: {(int)response.StatusCode} " +
                        $"{response.ReasonPhrase}\n{error}");
                }

                IssueEntity? updatedIssue =
                    await response.Content
                        .ReadFromJsonAsync<IssueEntity>(_jsonOptions);

                if (updatedIssue == null)
                {
                    throw new Exception(
                        "The API returned an empty issue response.");
                }

                return updatedIssue;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(
                    "Unable to connect to the Issues API.",
                    ex);
            }
        }


        // =========================================================
        // DELETE ISSUE
        // DELETE: /api/issues/{partitionKey}/{rowKey}
        // =========================================================

        public async Task<bool> DeleteIssueAsync(string partitionKey, string rowKey)
        {
            try
            {
                string url =
                    $"{ApiUrl}/" +
                    $"{Uri.EscapeDataString(partitionKey)}/" +
                    $"{Uri.EscapeDataString(rowKey)}";

                HttpResponseMessage response = await _httpClient.DeleteAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return false;
                }

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();

                    throw new Exception(
                        $"Failed to delete issue. " +
                        $"Status: {(int)response.StatusCode} " +
                        $"{response.ReasonPhrase}\n{error}");
                }

                return true;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(
                    "Unable to connect to the Issues API.",
                    ex);
            }
        }
    }
    
}