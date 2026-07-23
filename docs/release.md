# Release guide

Releases are automated via GitHub Actions. When a GitHub Release is published,
the `build.yml` workflow builds, tests, packs, and pushes the NuGet package
using OIDC trusted publishing — no secrets or manual uploads required.

## How to release

1. Make sure all changes are merged to `main` and CI is green.
2. Update the version in `Directory.Build.props` (`PackageVersion`) and/or
   `JustyBase.Netezza.csproj` (`JustyBaseNetezzaSqlVersion`) if needed.
3. Create a GitHub Release with a tag like `v0.1.0-preview.2`.
4. The `Build & Publish` workflow triggers automatically and pushes the
   `.nupkg` to nuget.org.

## Prerequisites

- **NuGet OIDC trusted publishing** must be configured for the
  `JustyBase.Netezza` package on nuget.org, linked to the
  `justybase/JustyBase.Netezza` repository.
- The repository secret `NUGET_USER` must be set (used by `nuget/login@v1`).

## Local pack (for testing)

```powershell
dotnet pack .\JustyBase.Netezza.csproj -c Release /p:PackageVersion=0.1.0-preview.1
```
