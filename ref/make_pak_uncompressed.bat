@echo off
setlocal enabledelayedexpansion

cd %~dp0

set repak_exe="%CD%\repak.exe"

for /f "tokens=1,* delims==" %%A in (settings.ini) do (
    if "%%A"=="pak_version" set pak_version=%%B
)

if not defined pak_version (
    echo Pak version not found in settings.ini.
    exit /b
)

if "%~1"=="" (
    echo No file dropped. Please drag and drop a pak folder onto this batch file.
    exit /b
)

for %%A in ("%~1") do (
    set "folder_name=%%~nA"
)

set pak_file_name="%folder_name%.pak"

%repak_exe% --aes-key 0x94464E8E5DD6B5537C09E0E12B20A12C83949F646E4EF1A224B5892ED44AD1D9  unpack  "%~1"
exit /b


