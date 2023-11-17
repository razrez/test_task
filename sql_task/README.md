```
docker compose up -d

sqlcmd -S localhost,1433 -d myDatabase -U SA -P YourStrong!Passw0rd -i .\init-sqript.sql

sqlcmd -S localhost,1433 -d myDatabase -U SA -P YourStrong!Passw0rd -i .\task-query.sql
```
![image](https://github.com/razrez/test_task/assets/70781439/a59ca451-15ab-404d-bdd6-867bef468126)
