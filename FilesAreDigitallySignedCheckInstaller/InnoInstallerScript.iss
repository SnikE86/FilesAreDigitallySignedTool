; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "FilesAreDigitallySignedTool"
#define MyAppVersion "3.1.0.0"
#define MyAppPublisher "Michael Ekins"
#define MyAppURL "www.michaelekins.co.uk"
#define MyAppExeName "FilesAreDigitallySignedTool.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{978C614F-708E-4E1A-B201-565925725DBA}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
Compression=lzma
SolidCompression=yes
WizardStyle=modern
OutputBaseFilename=FilesAreDigitallySignedTool
SetupIconFile="{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool.ico"
VersionInfoVersion=3.1.0.0

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\AuthenticodeExaminer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\AuthenticodeExaminer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\FilesAreDigitallySignedTool.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\Mono.Security.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool\bin\Release\System.Management.Automation.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}..\FilesAreDigitallySignedTool\FilesAreDigitallySignedTool.pdf"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

