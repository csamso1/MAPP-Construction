@echo off
set update_to_test="KB4019264"
set update_installed="null"
set null="null"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST2) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST2
set update_to_test="KB4019216"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST3) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST3
set update_to_test="KB4012598"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST4) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST4
set update_to_test="KB4019215"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST5) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST5
set update_to_test="KB4012598"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST6) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST6
set update_to_test="KB4019474"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST7) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST7
set update_to_test="KB4019472"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST8) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:TEST8
set update_to_test="KB4016871"
wmic qfe list | findstr "%update_to_test%"
IF ERRORLEVEL 1 (GOTO TEST8) else (
	set update_installed="%update_to_test%"
	GOTO RESULTS
)
:RESULTS
IF /i "%update_installed%" == "%null%" (echo "This machine is NOT protected. Update ASAP!!!") else (
	echo "This machine is protected, %update_installed% is installed."
)
pause