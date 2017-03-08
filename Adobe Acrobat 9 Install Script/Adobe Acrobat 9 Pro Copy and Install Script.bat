@ECHO OFF
SETLOCAL

SET _source="\\mapp-fs\applications\APPS\ScriptTesting\Adobe Acrobat 9 Pro"
SET _dest="C:\tools\Adobe 9"

SET _what= /B /E /Z /FFT 
:: /COPY:D :: Specifies the file properties to be copied. The following are the valid values for this option - D Data
:: /B :: copy files in Backup mode. 
:: /E :: Copy Subfolders, including Empty Subfolders.
:: /Z :: resume the transfer of a large file in mid-file instead of restarting
:: /FFT :: assume FAT File Times (2-second granularity

SET _options= /R:2 /W:2 /XO /TEE
:: /r:<N> Number of retries
:: /W:<N> Wait time, seconds
:: /TEE : Output to console window, as well as the log file

ROBOCOPY %_source% %_dest% %_what% %_options%

/wait

::Silent Install Call
msiexec /i "C:\tools\Adobe 9\AcroPro.msi" LANG_LIST=en_US /qb