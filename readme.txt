from the root:

1. docker compose up -f infra

2. dotnet ef migrations add InitialCreate --project src\Infrastructure --startup-project src\PresentationLayer --output-dir Persistence/Migrations

3. dotnet ef database update --project src\Infrastructure --startup-project src\PresentationLayer