[Setup]
AppName=Solutions Excel RTD
AppVersion=1.0.0
DefaultDirName={userappdata}\MSSolutions\RealTimeData
DisableProgramGroupPage=yes
OutputBaseFilename=Solutions.Excel.RTD.Setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=lowest
ArchitecturesInstallIn64BitMode=x64

[Files]
Source: "bin\Release\com.btgpactual.solution.excel.rtd.dll"; \
DestDir: "{app}"; Flags: ignoreversion

; ============================================================
; REGISTRO COM — PER USER (SEM ADMIN)
; ============================================================

[Registry]

; ------------------------------------------------------------
; ProgID
; ------------------------------------------------------------

Root: HKCU; \
Subkey: "Software\Classes\solutions.rtd.hub"; \
ValueType: string; ValueName: ""; \
ValueData: "Solutions Excel RTD Server"

Root: HKCU; \
Subkey: "Software\Classes\solutions.rtd.hub\CLSID"; \
ValueType: string; ValueName: ""; \
ValueData: "{C36E87B7-46E0-4842-B93D-89331AAECF3E}"

; ------------------------------------------------------------
; CLSID
; ------------------------------------------------------------

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}"; \
ValueType: string; ValueName: ""; \
ValueData: "Solutions Excel RTD Server"

; ------------------------------------------------------------
; InprocServer32  (CHAVE CRÍTICA)
; ------------------------------------------------------------

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: ""; \
ValueData: "mscoree.dll"

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: "ThreadingModel"; \
ValueData: "Both"

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: "Class"; \
ValueData: "com.btgpactual.solutions.excel.addin.rtd.RtdServer"

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: "Assembly"; \
ValueData: "com.btgpactual.solution.excel.rtd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: "RuntimeVersion"; \
ValueData: "v4.0.30319"

Root: HKCU; \
Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}\InprocServer32"; \
ValueType: string; ValueName: "CodeBase"; \
ValueData: "file:///{app}\com.btgpactual.solution.excel.rtd.dll"

; ------------------------------------------------------------
; Auto remove on uninstall
; ------------------------------------------------------------

Root: HKCU; Subkey: "Software\Classes\solutions.rtd.hub"; Flags: deletekey
Root: HKCU; Subkey: "Software\Classes\CLSID\{{C36E87B7-46E0-4842-B93D-89331AAECF3E}}"; Flags: deletekey