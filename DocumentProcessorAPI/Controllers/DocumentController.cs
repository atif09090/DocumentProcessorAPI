using DocumentProcessorAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentProcessorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentProcessor _processor;

        public DocumentController(IDocumentProcessor processor)
        {
            _processor = processor;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadDocument(IFormFile file, CancellationToken cancellationToken)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            try
            {
                var documentId = await _processor.ProcessDocumentAsync(file, cancellationToken);
                return Ok(new { DocumentId = documentId });
            }
            catch (TaskCanceledException)
            {
                return StatusCode(499, "Request canceled by client.");
            }
        }
    }

}
