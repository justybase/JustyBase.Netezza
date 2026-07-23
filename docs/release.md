# Manual release guide

CI verifies builds, tests and package artifacts but does not publish anything.

1. Build and test the Release solution against the intended
   `JustyBase.NetezzaSql*` package version.
2. Pack with a chosen SemVer prerelease, for example:
   `dotnet pack .\JustyBase.Netezza.csproj -c Release /p:PackageVersion=0.1.0-preview.1`.
3. Inspect the package and symbols, create the GitHub tag/release yourself,
   then upload the package to NuGet yourself.

Do not store NuGet credentials in this repository.
