namespace DocumentProcessorAPI.Data
{
    public class Document
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public DateTime ProcessedAt { get; set; }
    }
}
