using DocumentProcessorAPI.Data;

namespace DocumentProcessorAPI.Services
{
    public class DocumentProcessor : IDocumentProcessor
    {
        private readonly AppDbContext _context;
        private readonly ILogger<DocumentProcessor> _logger;

        public DocumentProcessor(AppDbContext context, ILogger<DocumentProcessor> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Guid> ProcessDocumentAsync(IFormFile file, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();

            // Simulate OCR Processing
            _logger.LogInformation("Starting processing for document {DocumentId}", id);
            await Task.Delay(5000, cancellationToken); // Simulate OCR or external API
            _logger.LogInformation("Finished processing for document {DocumentId}", id);

            var document = new Document
            {
                Id = id,
                FileName = file.FileName,
                ProcessedAt = DateTime.UtcNow
            };

            _context.Documents.Add(document);
            await _context.SaveChangesAsync(cancellationToken); // Important!
            return id;
        }
    }
}
