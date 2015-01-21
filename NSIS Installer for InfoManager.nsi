; InfoManager Installer NSIS Script
; get NSIS at http://nsis.sourceforge.net/Download
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

AddBrandingImage top 20
Icon "Resources\16x16_log.ico"
Caption "InfoManager Installer"
Name "InfoManager"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing InfoManager. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\DeavmiOSS

OutFile "bin\Release\InfoManager-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "InfoManager Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\InfoManager.exe"
  WriteUninstaller "InfoManager-Uninst.exe"
SectionEnd

Section "InfoManager Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\InfoManager.lnk" "$INSTDIR\InfoManager.exe" "" "$INSTDIR\InfoManager.exe" "" "" "" "Info Manager"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall InfoManager.lnk" "$INSTDIR\InfoManager-Uninst.exe" "" "" "" "" "" "Uninstall Info Manager"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "InfoManager Desktop Shortcut"
  CreateShortCut "$DESKTOP\InfoManager.lnk" "$INSTDIR\InfoManager.exe" "" "$INSTDIR\InfoManager.exe" "" "" "" "Info Manager"
SectionEnd

Section "InfoManager Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\InfoManager.lnk" "$INSTDIR\InfoManager.exe" "" "$INSTDIR\InfoManager.exe" "" "" "" "Info Manager"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install InfoManager. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] Resources\16x16_log.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/InfoManager/blob/master/README.md#infomanager-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete "$INSTDIR\InfoManager-Uninst.exe"   ; Remove Application Files
  Delete "$INSTDIR\InfoManager.exe"
  RMDir $INSTDIR
  
  Delete "$SMPROGRAMS\DeavmiOSS\InfoManager.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall InfoManager.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete "$DESKTOP\InfoManager.lnk"   ; Remove Desktop Shortcut
  Delete "$QUICKLAUNCH\InfoManager.lnk"   ; Remove Quick Launch shortcut
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall InfoManager. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
