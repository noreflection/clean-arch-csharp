from the root:
dotnet ef database update --project src\Infrastructure --startup-project src\PresentationLayer

dotnet ef migrations add InitialCreate --project src\Infrastructure --startup-project src\PresentationLayer --output-dir Persistence/Migrations