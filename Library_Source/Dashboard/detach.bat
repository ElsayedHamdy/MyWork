@echo off
TITLE Detach DateBase
sqlcmd -E -S (LocalDB)\MSSQLLocalDB -d master -Q "EXEC sp_detach_db [Library], [true]"
timeout /t 2 /nobreak>nul
pause