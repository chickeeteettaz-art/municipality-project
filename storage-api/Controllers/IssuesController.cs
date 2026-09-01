using Azure;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using muni_class_library;

namespace storage_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly TableClient _tableClient;
        private readonly ILogger<IssuesController> _logger;

        public IssuesController(IConfiguration configuration,ILogger<IssuesController> logger)
        {
            _logger = logger;

            string? connectionString = configuration.GetConnectionString("AzureStorage");

            string tableName = configuration["AzureTableStorage:TableName"]
                ?? "issues";

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Azure Storage connection string is not configured.");
            }

            _tableClient = new TableClient(connectionString, tableName);

            // Create the table if it doesn't already exist
            _tableClient.CreateIfNotExists();
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<IssueEntity>>> GetIssues()
        {
            try
            {
                List<IssueEntity> issues = new();

                await foreach (IssueEntity issue in _tableClient.QueryAsync<IssueEntity>())
                {
                    issues.Add(issue);
                }

                return Ok(issues);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving issues from Azure Table Storage.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An error occurred while retrieving issues.",
                        error = ex.Message
                    });
            }
        }


        // =========================================================
        // GET: api/issues/{partitionKey}/{rowKey}
        // Get a single issue
        // =========================================================

        [HttpGet("{partitionKey}/{rowKey}")]
        public async Task<ActionResult<IssueEntity>> GetIssue(string partitionKey,string rowKey)
        {
            try
            {
                Response<IssueEntity> response =
                    await _tableClient.GetEntityAsync<IssueEntity>(
                        partitionKey,
                        rowKey);

                return Ok(response.Value);
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Issue not found."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving issue {PartitionKey}/{RowKey}.",
                    partitionKey,
                    rowKey);

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An error occurred while retrieving the issue.",
                        error = ex.Message
                    });
            }
        }


       
        [HttpPost]
        public async Task<ActionResult<IssueEntity>> CreateIssue([FromBody] IssueEntity issue)
        {
            try
            {
                if (issue == null)
                {
                    return BadRequest(new
                    {
                        message = "Issue data is required."
                    });
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(issue.Title))
                {
                    return BadRequest(new
                    {
                        message = "Title is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.Location))
                {
                    return BadRequest(new
                    {
                        message = "Location is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.Description))
                {
                    return BadRequest(new
                    {
                        message = "Description is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.IssueCategory))
                {
                    return BadRequest(new
                    {
                        message = "Issue category is required."
                    });
                }

                // Use a fixed partition for issues
                issue.PartitionKey = "Issues";

                // Generate a unique RowKey
                issue.RowKey = Guid.NewGuid().ToString();

                // Azure Table Storage will generate this
                issue.Timestamp = null;

                // Insert the issue
                await _tableClient.AddEntityAsync(issue);

                return CreatedAtAction(
                    nameof(GetIssue),
                    new
                    {
                        partitionKey = issue.PartitionKey,
                        rowKey = issue.RowKey
                    },
                    issue);
            }
            catch (RequestFailedException ex)
            {
                _logger.LogError(
                    ex,
                    "Azure Table Storage error while creating issue.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "Failed to store the issue.",
                        error = ex.Message
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Unexpected error while creating issue.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An unexpected error occurred.",
                        error = ex.Message
                    });
            }
        }


        
        [HttpPut("{partitionKey}/{rowKey}")]
        public async Task<ActionResult<IssueEntity>> UpdateIssue(string partitionKey, string rowKey,[FromBody] IssueEntity issue)
        {
            try
            {
                if (issue == null)
                {
                    return BadRequest(new
                    {
                        message = "Issue data is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.Title))
                {
                    return BadRequest(new
                    {
                        message = "Title is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.Location))
                {
                    return BadRequest(new
                    {
                        message = "Location is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.Description))
                {
                    return BadRequest(new
                    {
                        message = "Description is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(issue.IssueCategory))
                {
                    return BadRequest(new
                    {
                        message = "Issue category is required."
                    });
                }

                // Ensure the keys cannot be changed by the frontend
                issue.PartitionKey = partitionKey;
                issue.RowKey = rowKey;

                // Replace the existing entity
                await _tableClient.UpdateEntityAsync(
                    issue,
                    ETag.All,
                    TableUpdateMode.Replace);

                return Ok(issue);
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Issue not found."
                });
            }
            catch (RequestFailedException ex)
            {
                _logger.LogError(
                    ex,
                    "Azure Table Storage error while updating issue.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "Failed to update the issue.",
                        error = ex.Message
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Unexpected error while updating issue.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An unexpected error occurred.",
                        error = ex.Message
                    });
            }
        }


        // =========================================================
        // DELETE: api/issues/{partitionKey}/{rowKey}
        // Delete an issue
        // =========================================================

        [HttpDelete("{partitionKey}/{rowKey}")]
        public async Task<IActionResult> DeleteIssue(string partitionKey, string rowKey)
        {
            try
            {
                await _tableClient.DeleteEntityAsync(
                    partitionKey,
                    rowKey);

                return Ok(new
                {
                    message = "Issue deleted successfully."
                });
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Issue not found."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error deleting issue {PartitionKey}/{RowKey}.",
                    partitionKey,
                    rowKey);

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An error occurred while deleting the issue.",
                        error = ex.Message
                    });
            }
        }
    }
}