
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using muni_class_library;

namespace municipality_app.Services
{
    public class AnnouncementServices
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public AnnouncementServices()
        {
            var handler = new HttpClientHandler
            {
                // Development only - accepts the ASP.NET Core
                // self-signed HTTPS certificate.
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            _httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:7299/api/announcements/"),
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        /// <summary>
        /// Constructor for dependency injection/testing.
        /// </summary>
        public AnnouncementServices(HttpClient httpClient)
        {
            _httpClient = httpClient ??
                          throw new ArgumentNullException(nameof(httpClient));

            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress =
                    new Uri("https://localhost:7299/api/announcements/");
            }
        }

        private static void NormalizeAnnouncementDate(Announcement announcement)
        {
            if (announcement == null)
                return;

            // Azure Table Storage requires DateTime values to have Kind = Utc.
            announcement.AnnouncementDate =
                DateTime.SpecifyKind(
                    announcement.AnnouncementDate,
                    DateTimeKind.Utc);
        }

        // ============================================================
        // GET ALL ANNOUNCEMENTS
        // GET /api/announcements
        // ============================================================
        public async Task<List<Announcement>> GetAllAnnouncementsAsync()
        {
            try
            {
                using HttpResponseMessage response =
                    await _httpClient.GetAsync(string.Empty);

                if (!response.IsSuccessStatusCode)
                {
                    await ThrowApiExceptionAsync(
                        response,
                        "Failed to retrieve announcements.");
                }

                var announcements =
                    await response.Content.ReadFromJsonAsync<List<Announcement>>(
                        JsonOptions);

                return announcements ?? new List<Announcement>();
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception(
                    "The request to retrieve announcements timed out.",
                    ex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An unexpected error occurred while retrieving announcements.",
                    ex);
            }
        }

        // ============================================================
        // GET SINGLE ANNOUNCEMENT
        // GET /api/announcements/{partitionKey}/{rowKey}
        // ============================================================
        public async Task<Announcement?> GetAnnouncementAsync(
            string partitionKey,
            string rowKey)
        {
            ValidateKeys(partitionKey, rowKey);

            try
            {
                string url = $"{Uri.EscapeDataString(partitionKey)}/" +
                             $"{Uri.EscapeDataString(rowKey)}";

                using HttpResponseMessage response =
                    await _httpClient.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                if (!response.IsSuccessStatusCode)
                {
                    await ThrowApiExceptionAsync(
                        response,
                        "Failed to retrieve the announcement.");
                }

                return await response.Content.ReadFromJsonAsync<Announcement>(
                    JsonOptions);
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception(
                    "The request to retrieve the announcement timed out.",
                    ex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"An unexpected error occurred while retrieving " +
                    $"announcement {partitionKey}/{rowKey}.",
                    ex);
            }
        }

        // ============================================================
        // CREATE ANNOUNCEMENT
        // POST /api/announcements
        // ============================================================
        public async Task<Announcement> CreateAnnouncementAsync(
    Announcement announcement)
        {
            if (announcement == null)
                throw new ArgumentNullException(nameof(announcement));

            try
            {
                // Azure Table Storage requires UTC DateTime values.
                NormalizeAnnouncementDate(announcement);

                using HttpResponseMessage response =
                    await _httpClient.PostAsJsonAsync(
                        string.Empty,
                        announcement,
                        JsonOptions);

                if (!response.IsSuccessStatusCode)
                {
                    await ThrowApiExceptionAsync(
                        response,
                        "Failed to create the announcement.");
                }

                var createdAnnouncement =
                    await response.Content.ReadFromJsonAsync<Announcement>(
                        JsonOptions);

                if (createdAnnouncement == null)
                {
                    throw new Exception(
                        "The API created the announcement but returned no data.");
                }

                return createdAnnouncement;
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception(
                    "The request to create the announcement timed out.",
                    ex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An unexpected error occurred while creating the announcement.",
                    ex);
            }
        }

        // ============================================================
        // UPDATE ANNOUNCEMENT
        // PUT /api/announcements/{partitionKey}/{rowKey}
        // ============================================================
        public async Task<Announcement> UpdateAnnouncementAsync(
            string partitionKey,
            string rowKey,
            Announcement announcement)
        {
            ValidateKeys(partitionKey, rowKey);

            if (announcement == null)
            {
                throw new ArgumentNullException(nameof(announcement));
            }

            try
            {
                // The API uses these values to identify the Azure Table entity.
                announcement.PartitionKey = partitionKey;
                announcement.RowKey = rowKey;

                string url = $"{Uri.EscapeDataString(partitionKey)}/" +
                             $"{Uri.EscapeDataString(rowKey)}";

                using HttpResponseMessage response =
                    await _httpClient.PutAsJsonAsync(
                        url,
                        announcement,
                        JsonOptions);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new KeyNotFoundException(
                        $"Announcement {partitionKey}/{rowKey} was not found.");
                }

                if (!response.IsSuccessStatusCode)
                {
                    await ThrowApiExceptionAsync(
                        response,
                        "Failed to update the announcement.");
                }

                var updatedAnnouncement =
                    await response.Content.ReadFromJsonAsync<Announcement>(
                        JsonOptions);

                if (updatedAnnouncement == null)
                {
                    throw new Exception(
                        "The API updated the announcement but returned no data.");
                }

                return updatedAnnouncement;
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception(
                    "The request to update the announcement timed out.",
                    ex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"An unexpected error occurred while updating " +
                    $"announcement {partitionKey}/{rowKey}.",
                    ex);
            }
        }

        // ============================================================
        // DELETE ANNOUNCEMENT
        // DELETE /api/announcements/{partitionKey}/{rowKey}
        // ============================================================
        public async Task<bool> DeleteAnnouncementAsync(
            string partitionKey,
            string rowKey)
        {
            ValidateKeys(partitionKey, rowKey);

            try
            {
                string url = $"{Uri.EscapeDataString(partitionKey)}/" +
                             $"{Uri.EscapeDataString(rowKey)}";

                using HttpResponseMessage response =
                    await _httpClient.DeleteAsync(url);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }

                if (!response.IsSuccessStatusCode)
                {
                    await ThrowApiExceptionAsync(
                        response,
                        "Failed to delete the announcement.");
                }

                return true;
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception(
                    "The request to delete the announcement timed out.",
                    ex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"An unexpected error occurred while deleting " +
                    $"announcement {partitionKey}/{rowKey}.",
                    ex);
            }
        }

        // ============================================================
        // VALIDATION
        // ============================================================
        private static void ValidateKeys(
            string partitionKey,
            string rowKey)
        {
            if (string.IsNullOrWhiteSpace(partitionKey))
            {
                throw new ArgumentException(
                    "Partition key is required.",
                    nameof(partitionKey));
            }

            if (string.IsNullOrWhiteSpace(rowKey))
            {
                throw new ArgumentException(
                    "Row key is required.",
                    nameof(rowKey));
            }
        }

        // ============================================================
        // API ERROR HANDLING
        // ============================================================
        private static async Task ThrowApiExceptionAsync(
            HttpResponseMessage response,
            string defaultMessage)
        {
            string errorDetails = string.Empty;

            try
            {
                errorDetails =
                    await response.Content.ReadAsStringAsync();
            }
            catch
            {
                // Ignore errors while reading the error response.
            }

            string message = string.IsNullOrWhiteSpace(errorDetails)
                ? defaultMessage
                : $"{defaultMessage} " +
                  $"Status: {(int)response.StatusCode} " +
                  $"{response.StatusCode}. " +
                  $"Details: {errorDetails}";

            throw new HttpRequestException(message);
        }
    }
}

