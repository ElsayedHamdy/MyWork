@echo off
TITLE Attach Library DataBase
set P=%~dp0
set P=%P:~0,-1%
sqlcmd -E -S (LocalDB)\MSSQLLocalDB -d master -Q "EXEC sp_attach_db @dbname=N'Library', @filename1 = N'%P%\Library.mdf',@filename2 = N'%P%\Library_log.ldf'"
timeout /t 2 /nobreak>nul
pause


