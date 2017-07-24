@ echo off
set /p @project_name="Enter the Project Number and Name: "
:define_region
set /p @region="Enter the region (Enter LA or DAL): "
IF /i "%@region%"=="LA" (
	set /p @RCProject="Is this a Raising Canes Project? (Enter Y or N): "
	IF /i "%@RCProject%"=="Y" (
		xcopy "D:\Projects\MAPP Commercial\MAPP LA\Template_RC" "D:\Projects\MAPP Commercial\MAPP LA\%@project_name%" /O /X /E /H /K
	)
	ELSE IF /i "%@RCProject%"=="N" (
		xcopy "D:\Projects\MAPP Commercial\MAPP LA\Template_RC" "D:\Projects\MAPP Commercial\MAPP LA\%@project_name%" /O /X /E /H /K
	)
	::Line below is for testing on local machine
	::xcopy "C:\Users\Clayton\Desktop\TestDir" "C:\Users\Clayton\Desktop\TestDirEmpty\%@project_name%" /O /X /E /H /K
	echo %@project_name% created in MAPP LA
	)
ELSE IF /i "%@region%"=="DAL" (
	set /p @Take5Project="Is this a Take 5 Project? (Enter Y or N): "
	IF /i "%@Take5Project%"=="Y" (
		xcopy "D:\Projects\MAPP Commercial\MAPP DAL\Take 5 Program\Template" "D:\Projects\MAPP Commercial\MAPP DAL\Take 5 Program\%@project_name%" /O /X /E /H /K
		echo %@project_name% created in MAPP DAL\Take 5 Program
	) ELSE IF /i "%@Take5Project%"=="N" (
		xcopy "D:\Projects\MAPP Commercial\MAPP DAL\Template" "D:\Projects\MAPP Commercial\MAPP DAL\%@project_name%" /O /X /E /H /K )
	::Line below is for testing on local machine
	::xcopy "C:\Users\Clayton\Desktop\TestDir" "C:\Users\Clayton\Desktop\TestDirEmpty\%@project_name%" /O /X /E /H /K
		echo %@project_name% created in MAPP DAL
	)
ELSE (
	echo "Invalid region provided, please run again and specify 'LA' or 'Dal'"
	goto:define_region
	)
pause
::Removed Code below
:: ELSE IF /i "%@region%"=="Take5" (
:: 	xcopy "D:\Projects\MAPP Commercial\MAPP DAL\Take 5 Program\Template" "D:\Projects\MAPP Commercial\MAPP DAL\Take 5 Program\%@project_name%" /O /X /E /H /K
:: 	echo %@project_name% created in MAPP DAL\Take 5 Program
:: 	) 