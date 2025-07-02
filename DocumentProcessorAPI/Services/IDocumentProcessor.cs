namespace DocumentProcessorAPI.Services
{
    public interface IDocumentProcessor
    {
        Task<Guid> ProcessDocumentAsync(IFormFile file, CancellationToken cancellationToken);
    }
}
