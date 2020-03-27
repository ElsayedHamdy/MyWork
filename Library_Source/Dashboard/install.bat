@echo off
TITLE MYLibrary Installer
setlocal enabledelayedexpansion
SET Result=false
set P=%~dp0
set P=%P:~0,-1%
NET SESSION >nul 2>&1
IF %ERRORLEVEL% EQU 0 (
IF %PROCESSOR_ARCHITECTURE%==AMD64 (
IF EXIST "%P%\x64\SqlLocalDB.msi" ( IF EXIST "%P%\x64\msodbcsql.msi" ( IF EXIST "%P%\x64\MsSqlCmdLnUtils.msi" (
msiexec /i "%P%\x64\SqlLocalDB.msi" /qn /quiet /passive /norestart IACCEPTSQLLOCALDBLICENSETERMS=YES
msiexec /i "%P%\x64\msodbcsql.msi" /qn /quiet /passive /norestart IACCEPTMSODBCSQLLICENSETERMS=YES ADDLOCAL=ALL
msiexec /i "%P%\x64\MsSqlCmdLnUtils.msi" /qn /quiet /passive /norestart IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES
@echo @echo off>continueinstallation.bat
@echo TITLE Continue Installation>>continueinstallation.bat
@echo sqllocaldb delete mssqllocaldb>>continueinstallation.bat
@echo sqllocaldb create mssqllocaldb>>continueinstallation.bat
@echo sqllocaldb start mssqllocaldb>>continueinstallation.bat
@echo CALL "%P%\attach.bat">>continueinstallation.bat
@echo del %P%\continueinstallation.bat /f /q>>continueinstallation.bat
reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce /v continueinstallation /t REG_SZ /d "%P%\continueinstallation.bat"
reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce /v continueinstallation /t REG_SZ /d "%P%\continueinstallation.bat"
@echo You Need To Reboot Your PC to Continue your Installation Save Your Current Work And Then Press any key to Reboot.
SET /P response="Press any key to reboot....."
@echo your pc is going to restart within 10 seconds.
SHUTDOWN -r -t 10
)ELSE (
@echo Not Found \x64\MsSqlCmdLnUtils.msi
))ELSE (
@echo Not Found \x64\msodbcsql.msi
))ELSE (
@echo Not Found \x64\SqlLocalDB.msi
))ELSE (
IF EXIST "%P%\x32\SqlLocalDB.msi" ( IF EXIST "%P%\x32\msodbcsql.msi" ( IF EXIST "%P%\x32\MsSqlCmdLnUtils.msi" (
msiexec /i "%P%\x32\SqlLocalDB.msi" /qn /quiet /passive /norestart IACCEPTSQLLOCALDBLICENSETERMS=YES
msiexec /i "%P%\x32\msodbcsql.msi" /qn /quiet /passive /norestart IACCEPTMSODBCSQLLICENSETERMS=YES ADDLOCAL=ALL
msiexec /i "%P%\x32\MsSqlCmdLnUtils.msi" /qn /quiet /passive /norestart IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES
@echo @echo off>continueinstallation.bat
@echo TITLE Continue Installation>>continueinstallation.bat
@echo sqllocaldb delete mssqllocaldb>>continueinstallation.bat
@echo sqllocaldb create mssqllocaldb>>continueinstallation.bat
@echo sqllocaldb start mssqllocaldb>>continueinstallation.bat
@echo CALL "%P%\attach.bat">>continueinstallation.bat
@echo del %P%\continueinstallation.bat /f /q>>continueinstallation.bat
reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce /v continueinstallation /t REG_SZ /d "%P%\continueinstallation.bat"
reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce /v continueinstallation /t REG_SZ /d "%P%\continueinstallation.bat"
@echo You Need To Reboot Your PC to Continue your Installation Save Your Current Work And Then Press any key to Reboot.
SET /P response="Press any key to reboot....."
@echo your pc is going to restart within 10 seconds.
SHUTDOWN -r -t 10
)ELSE (
@echo Not Found \x32\MsSqlCmdLnUtils.msi
))ELSE (
@echo Not Found \x32\msodbcsql.msi
))ELSE (
@echo Not Found \x32\SqlLocalDB.msi
)))ELSE (
    @ECHO Please Run install.bat with Administrator PRIVILEGES.
    @ECHO Right click install.bat choose run as administrator.
)
pause