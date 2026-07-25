# JustyBase.Netezza — moved

> **This repository is archived.** The `JustyBase.Netezza` library now lives in
> [`justybase/JustyBase.NetezzaSql`](https://github.com/justybase/JustyBase.NetezzaSql)
> under [`JustyBase.Netezza/`](https://github.com/justybase/JustyBase.NetezzaSql/tree/master/JustyBase.Netezza).

## Why

`JustyBase.Netezza` always depended on `JustyBase.NetezzaSqlParser` and
`JustyBase.NetezzaDdl`. Keeping them in separate repositories forced dual
checkouts, staggered NuGet releases, and fragile local `ProjectReference`
detection. The NuGet package id **`JustyBase.Netezza` is unchanged**.

## Where to go

| Need | Location |
|------|----------|
| Source | https://github.com/justybase/JustyBase.NetezzaSql/tree/master/JustyBase.Netezza |
| NuGet | https://www.nuget.org/packages/JustyBase.Netezza/ |
| Issues / PRs | https://github.com/justybase/JustyBase.NetezzaSql/issues |

## Consumers

Clone only `JustyBase.NetezzaSql` as a sibling of `JustyBase` / `JustyBase.Legacy`.
MSBuild will pick up local project references for parser, DDL, catalog, and
`JustyBase.Netezza` from that single checkout.
