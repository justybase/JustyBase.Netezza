# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- GitHub Actions CI workflow with cross-platform testing (Ubuntu + Windows)
- GitHub Actions build & publish workflow with NuGet OIDC trusted publishing
- Comprehensive `.gitignore` based on official github/gitignore templates (VisualStudio + JetBrains)

### Changed
- `RepositoryUrl` updated to `https://github.com/justybase/JustyBase.Netezza`
- `JustyBaseNetezzaSqlVersion` default changed from `1.0.0` to `0.1.0-preview.1` to match NuGet package availability
- CI workflows explicitly set `UseLocalJustyBaseLibraries=false` to always use NuGet packages
- Updated action versions: `actions/checkout@v7`, `actions/setup-dotnet@v6`, `actions/upload-artifact@v7`

### Fixed
- NuGet restore failure in CI due to incorrect package version (`1.0.0` → `0.1.0-preview.1`)

## [0.1.0-preview.1] - 2026-07-23

### Added
- Initial release of JustyBase.Netezza library
- `NetezzaSchemaSnapshot` — immutable, UI-free metadata DTOs for Netezza database schema
- `NetezzaSchemaProviderAdapter` — loads snapshots into parser's `InMemorySchemaProvider`
- `NetezzaDdlInputFactory` — converts neutral models to DDL input types for `CREATE TABLE / VIEW / PROCEDURE`
- `SqlCompletionMergePolicy` — engine-first vs. legacy fallback decision for SQL completion
- `NetezzaResult<T>` — result object pattern for expected failure modes
- `ServiceCollectionExtensions.AddJustyBaseNetezza()` — DI registration for all services
- Full XML documentation for all public types and members
- Native AOT compatibility (`IsAotCompatible = true`)
- Unit tests for all core functionality
- CI/CD pipeline with GitHub Actions

### Dependencies
- `JustyBase.NetezzaSqlParser` — SQL lexer, parser, AST, completion engine, linter
- `JustyBase.NetezzaDdl` — DDL text builder
- `Microsoft.Extensions.DependencyInjection.Abstractions` — DI abstractions

### Target Framework
- .NET 10

---

[Unreleased]: https://github.com/justybase/JustyBase.Netezza/compare/v0.1.0-preview.1...HEAD
[0.1.0-preview.1]: https://github.com/justybase/JustyBase.Netezza/releases/tag/v0.1.0-preview.1
