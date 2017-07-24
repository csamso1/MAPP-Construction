@echo off
set /p @project_name="Enter the Project Number and Name: "
:define_region
set /p @region="Enter the region (Enter LA or DAL): "
echo region = %@region%
IF /i "%@region%"=="LA" (goto LA) ELSE goto DALLAS
:LA
echo LA project script is executing
set /p @RCProject="Is this a Raising Canes Project? (Enter Y or N): "
IF /i "%@RCProject%"=="Y" (goto LARC) ELSE goto LASTD
:LARC
echo "LARC executing"
xcopy "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP LA\Template_RC" "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP LA\%@project_name%" /O /X /E /H /K /I /S
echo "%@project_name% created in MAPP LA"
Goto end
:LASTD
echo "LASTD Executing"
xcopy "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP LA\Template" "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP LA\%@project_name%" /O /X /E /H /K /I /S
echo "non-raising canes project: %@project_name% created in MAPP LA"
Goto end
:DALLAS
echo Dallas project script is executing
set /p @Take5Project="Is this a Take 5 Project? (Enter Y or N): "
IF /i "%@Take5Project%"=="Y" (goto DALTake5) ELSE goto DALSTD
:DALSTD
echo "DALSTD Executing"
xcopy "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP DAL\Template" "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP DAL\%@project_name%" /O /X /E /H /K /I /S
echo "%@project_name% created in MAPP DAL"
Goto end
:DALTake5
echo "DALTake5 Executing"
xcopy "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP DAL\Take 5 Program\Template" "C:\Users\Clayton\Documents\MAPP\Script Testing\MAPP DAL\Take 5 Program\%@project_name%" /O /X /E /H /K /I /S
echo "%@project_name% created in MAPP DAL\Take 5 Program"
Goto end
:end
pause