using Azure;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using muni_class_library;

namespace storage_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        private readonly TableClient _tableClient;
        private readonly ILogger<IssuesController> _logger;

        public AnnouncementsController(IConfiguration configuration, ILogger<IssuesController> logger)
        {
            _logger = logger;

            string? connectionString = configuration.GetConnectionString("AzureStorage");

            string tableName = configuration["AzureTableStorage:AnnouncementsTableName"] ?? "issues";

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Azure Storage connection string is not configured.");
            }

            _tableClient = new TableClient(connectionString, tableName);
            _tableClient.CreateIfNotExists();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Announcement>>> GetAnnouncements()
        {
            try
            {
                List<Announcement> announcements = new();

                await foreach (Announcement announcement in _tableClient.QueryAsync<Announcement>())
                {
                    announcements.Add(announcement);
                }

                return Ok(announcements);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Error retrieving announcements from Azure Table Storage.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An error occurred while retrieving issues.",
                        error = ex.Message
                    });
            }
        }

        [HttpGet("{partitionKey}/{rowKey}")]
        public async Task<ActionResult<Announcement>> GetAnnouncement(string partitionKey, string rowKey)
        {
            try
            {
                Response<Announcement> response = await _tableClient.GetEntityAsync<Announcement>(partitionKey, rowKey);
                return Ok(response.Value);
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Announement not found."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving announcement {PartitionKey}/{RowKey}.", partitionKey, rowKey);

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
        public async Task<ActionResult<IssueEntity>> CreateAnnouncement([FromBody] Announcement announcement)
        {
            try
            {
                if (announcement == null)
                {
                    return BadRequest(new
                    {
                        message = "Announcment data is required."
                    });
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(announcement.Title))
                {
                    return BadRequest(new
                    {
                        message = "Title is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.Location))
                {
                    return BadRequest(new
                    {
                        message = "Location is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.Description))
                {
                    return BadRequest(new
                    {
                        message = "Description is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.AnnouncementDate.ToString()))
                {
                    return BadRequest(new
                    {
                        message = "Announcement date is required."
                    });
                }

                announcement.PartitionKey = "Announcements";
                announcement.RowKey = Guid.NewGuid().ToString();
                announcement.Timestamp = null;
                await _tableClient.AddEntityAsync(announcement);

                return CreatedAtAction(
                    nameof(GetAnnouncement),
                    new
                    {
                        partitionKey = announcement.PartitionKey,
                        rowKey = announcement.RowKey
                    },
                    announcement);
            }
            catch (RequestFailedException ex)
            {
                _logger.LogError(ex, "Azure Table Storage error while creating announcement.");

                return StatusCode(StatusCodes.Status500InternalServerError,
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
        public async Task<ActionResult<Announcement>> UpdateAnnouncement(string partitionKey, string rowKey, [FromBody] Announcement announcement)
        {
            try
            {
                if (announcement == null)
                {
                    return BadRequest(new
                    {
                        message = "Issue data is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.Title))
                {
                    return BadRequest(new
                    {
                        message = "Title is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.Location))
                {
                    return BadRequest(new
                    {
                        message = "Location is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.Description))
                {
                    return BadRequest(new
                    {
                        message = "Description is required."
                    });
                }

                if (string.IsNullOrWhiteSpace(announcement.AnnouncementDate.ToString()))
                {
                    return BadRequest(new
                    {
                        message = "Announcement date is required."
                    });
                }

                // Ensure the keys cannot be changed by the frontend
                announcement.PartitionKey = partitionKey;
                announcement.RowKey = rowKey;

                // Replace the existing entity
                await _tableClient.UpdateEntityAsync(
                    announcement,
                    ETag.All,
                    TableUpdateMode.Replace);

                return Ok(announcement);
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Announcement not found."
                });
            }
            catch (RequestFailedException ex)
            {
                _logger.LogError(
                    ex,
                    "Azure Table Storage error while updating announcement.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "Failed to update the announcement.",
                        error = ex.Message
                    });
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "Unexpected error while updating announcement.");

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = "An unexpected error occurred.",
                        error = ex.Message
                    });
            }
        }



        [HttpDelete("{partitionKey}/{rowKey}")]
        public async Task<IActionResult> DeleteAnnouncement(string partitionKey, string rowKey)
        {
            try
            {
                await _tableClient.DeleteEntityAsync(
                    partitionKey,
                    rowKey);

                return Ok(new
                {
                    message = "Announcement deleted successfully."
                });
            }
            catch (RequestFailedException ex)
                when (ex.Status == StatusCodes.Status404NotFound)
            {
                return NotFound(new
                {
                    message = "Announcement not found."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting announcement {PartitionKey}/{RowKey}.", partitionKey, rowKey);

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
