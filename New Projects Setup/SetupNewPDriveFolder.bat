@ echo off
set /p @project_name="Enter the Project Number and Name: "
:define_region
set /p @region="Enter the region (Either LA or DAL): "
IF /i "%@region%"=="LA" (
	xcopy "D:\Projects\MAPP Commercial\MAPP LA\Template" "D:\Projects\MAPP Commercial\MAPP LA\%@project_name%" /O /X /E /H /K
	::Line below is for testing on local machine
	::xcopy "C:\Users\Clayton\Desktop\TestDir" "C:\Users\Clayton\Desktop\TestDirEmpty\%@project_name%" /O /X /E /H /K
	echo %@project_name% created in MAPP LA
	) ELSE IF /i "%@region%"=="DAL" (
	xcopy "D:\Projects\MAPP Commercial\MAPP DAL\Template" "D:\Projects\MAPP Commercial\MAPP DAL\%@project_name%" /O /X /E /H /K
	::Line below is for testing on local machine
	::xcopy "C:\Users\Clayton\Desktop\TestDir" "C:\Users\Clayton\Desktop\TestDirEmpty\%@project_name%" /O /X /E /H /K
	echo %@project_name% created in MAPP DAL
	) ELSE (
	echo "Invalid region provided, please run again and specify 'LA' or 'Dal'"
	goto:define_region
	)
pause