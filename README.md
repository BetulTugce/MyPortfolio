# MyPortfolio

## Installation

1. **Clone the project:**

    ```bash
    git clone https://github.com/BetulTugce/MyPortfolio.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd MyPortfolio
    ```

3. **Configure `appsettings.json` File:**
   
   Before running the project, make sure to configure the `appsettings.json` file in the project. Update the `ConnectionStrings` section with your MSSQL Server connection string.

4. **Perform Database Migration:**
   
   To apply database migration, follow these steps:
   - Open Package Manager Console by navigating to Tools > NuGet Package Manager > Package Manager Console.
   - In the Package Manager Console, execute the command `add-migration InitialCreate` to create a migration for the initial database schema.
   - After the migration is created, apply it to the database by running the command `update-database`.

5. **Run the project:**

   Press `F5` to run the project.


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

## Support and Communication

If you encounter any issues or have feedback while using the project, feel free to [create an issue on GitHub](https://github.com/BetulTugce/MyPortfolio/issues). Moreover, if you wish to support or contribute to the project, you can do so by starring the [GitHub repository](https://github.com/BetulTugce/MyPortfolio) or making contributions to the codebase.