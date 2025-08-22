# Real-time Collaborative Document Editor

This project is a **real-time collaborative document editor** designed to allow multiple users to edit the same document simultaneously, with changes synchronized instantly. The application is built as a **distributed system**, orchestrated using **.NET Aspire** to manage its various microservices.

---

## Features

- **User Authentication**: Users can register and log in securely.
- **Document Management**: Create, view, edit, and delete documents with full control.
- **Real-time Collaboration**: Changes made by one user are instantly broadcasted to others.
- **Concurrency Handling**: Uses optimistic concurrency to prevent data conflicts during simultaneous edits.

---

## Technology Stack

The project is structured into several interconnected services to ensure scalability and maintainability.

| Component               | Technology                     |
|------------------------|---------------------------------|
| Orchestration          | .NET Aspire                    |
| Backend                | .NET 8 (C#)                    |
| Frontend               | Angular                        |
| Real-time Communication| ASP.NET Core SignalR           |
| Databases              | PostgreSQL (user data), MongoDB (documents) |
| Caching                | Redis                          |
