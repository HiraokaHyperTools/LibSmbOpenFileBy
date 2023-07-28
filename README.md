# LibSmbOpenFileBy

[![Nuget](https://img.shields.io/nuget/v/HiraokaHyperTools.LibSmbOpenFileBy)](https://www.nuget.org/packages/HiraokaHyperTools.LibSmbOpenFileBy)

Enumerate all `MSFT_SmbOpenFile` objects under `Root\Microsoft\Windows\SMB`

This runs only on Windows 8 (Windows Server 2012 R2) and later.

```cs
var results = new SearchOpenFileByPath().EnumAll();
```
