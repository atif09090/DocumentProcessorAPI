# 📄 Document Processor API

A real-world ASP.NET Core 8 Web API that demonstrates the **correct use of Cancellation Tokens** for long-running operations, such as document processing, database interactions, and graceful shutdowns in background services.

---

## 🚀 Features

- Upload documents for simulated processing (e.g., OCR, virus scanning).
- Handles client cancellation using `CancellationToken`.
- Persists processed document metadata using EF Core (InMemory).
- Graceful shutdown of background tasks using `IHostedService`.
- Lightweight and production-relevant — not a beginner example.

---

## 🔧 Tech Stack

- ASP.NET Core 8 Web API  
- Entity Framework Core (InMemory)  
- BackgroundService (Worker pattern)  
- Built-in dependency injection  
- Logging  

---

## 🧪 Endpoints

### `POST /api/document/upload`

Uploads a file for processing.

#### Request (multipart/form-data)

```bash
curl -X POST http://localhost:5000/api/document/upload \
  -F "file=@yourfile.pdf"
```

## 🏗️ Project Structure

```plaintext

DocumentProcessorAPI/
├── Controllers/            # Web API controllers
├── Services/               # Business logic
├── Background/             # HostedService for background tasks
├── Data/                   # EF Core context and models
├── Program.cs              # Entry point and DI configuration
└── README.md               # Project documentation
