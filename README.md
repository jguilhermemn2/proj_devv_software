# proj_devv_software

para subir ui e back end + bd

docker-compose up -d

UI:
http://localhost:4200/

API:
POST: http://localhost:8899/api/User
Body:
{
    "name":"Jose",
    "Email":"jose@impacta.com",
    "Password":"123"
}


MongoDB
Server: localhost:27017
User: admin
Senha: 123








[Registry]

; ProgID
Root: HKCR; Subkey: "MinhaEmpresa.ExcelRtd"; \
ValueType: string; ValueName: ""; ValueData: "Excel RTD Server"

Root: HKCR; Subkey: "MinhaEmpresa.ExcelRtd\CLSID"; \
ValueType: string; ValueData: "{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}"

; CLSID
Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}"; \
ValueType: string; ValueName: ""; ValueData: "Excel RTD Server"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: ""; ValueData: "mscoree.dll"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: "ThreadingModel"; ValueData: "Both"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: "Class"; ValueData: "MeuNamespace.RtdServer"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: "Assembly"; ValueData: "MinhaRtd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=abcd1234"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: "RuntimeVersion"; ValueData: "v4.0.30319"

Root: HKCR; Subkey: "CLSID\{9F9B3E6A-5F7D-4E52-9C5A-7C92E0F94A11}\InprocServer32"; \
ValueType: string; ValueName: "CodeBase"; \
ValueData: "file:///{app}\MinhaRtd.dll"

