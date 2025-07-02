namespace DocumentProcessorAPI.Background
{
    public class DocumentWorker : BackgroundService
    {
        private readonly ILogger<DocumentWorker> _logger;

        public DocumentWorker(ILogger<DocumentWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("DocumentWorker started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Running background scan...");
                await Task.Delay(3000, stoppingToken); // Simulated background task
            }

            _logger.LogInformation("DocumentWorker stopping.");
        }
    }

}
