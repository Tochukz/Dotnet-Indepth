#### Entity Framework Setup
How to Scaffold  DBContext from existing database (MySQL)
```bash
$ dotnet ef dbcontext scaffold "server=localhost;port=3306;database=app_db;user=root;password=;" Pomelo.EntityFrameworkCore.MySql -o Models
```

To customize the scaffolded code, you can use the following options:
```bash
$ dotnet ef dbcontext scaffold "your-connection-string" Pomelo.EntityFrameworkCore.MySql \
-o Models \
--context AppDbContext \
--use-database-names \
--no-onconfiguring \
--data-annotations
```

To select specific tables to scaffold, you can use the `--table` option:
```bash
$ dotnet ef dbcontext scaffold \
"server=localhost;port=3306;database=YourDb;user=yourUser;password=yourPassword;" \
Pomelo.EntityFrameworkCore.MySql \
-o Models \
--context AppDbContext \
--table users \
--table tenants \
```

Re-run with --force when updating:
```bash
$ dotnet ef dbcontext scaffold ... --force
```
