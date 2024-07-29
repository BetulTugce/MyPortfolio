# MyPortfolio

## Dependencies

- [Microsoft.EntityFrameworkCore.Design](https://learn.microsoft.com/tr-tr/ef/core/) v8.0.7
- [Microsoft.EntityFrameworkCore](https://learn.microsoft.com/tr-tr/ef/core/) v8.0.7
- [Microsoft.EntityFrameworkCore.SqlServer](https://learn.microsoft.com/tr-tr/ef/core/) v8.0.7
- [Microsoft.EntityFrameworkCore.Tools](https://learn.microsoft.com/tr-tr/ef/core/) v8.0.7

## Configuration

The `appsettings.json` file is not included in the repository as it contains sensitive information. Instead, you should create your own `appsettings.json` file with the following structure:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  //Veritabanı bağlantı dizesi..
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;Database=your_db_name;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True;"
  },
  "AllowedHosts": "*"
}
```