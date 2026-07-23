using JustyBase.Netezza.Abstractions;
using JustyBase.Netezza.Models;
using JustyBase.NetezzaSqlParser.Ast;
using JustyBase.NetezzaSqlParser.Visitor;

namespace JustyBase.Netezza.Schema;

/// <summary>Loads a neutral metadata snapshot into the parser's schema provider.</summary>
public static class NetezzaSchemaProviderAdapter
{
    /// <summary>Default singleton instance that implements <see cref="INetezzaSchemaProviderAdapter"/>.</summary>
    public static INetezzaSchemaProviderAdapter Default { get; } = new DefaultNetezzaSchemaProviderAdapter();

    /// <summary>Applies the snapshot to the given <paramref name="provider"/>.</summary>
    public static void Apply(
        InMemorySchemaProvider provider,
        NetezzaSchemaSnapshot snapshot,
        bool clear = true)
        => Default.Apply(provider, snapshot, clear);
}

internal sealed class DefaultNetezzaSchemaProviderAdapter : INetezzaSchemaProviderAdapter
{
    public void Apply(
        InMemorySchemaProvider provider,
        NetezzaSchemaSnapshot snapshot,
        bool clear = true)
    {
        ArgumentNullException.ThrowIfNull(provider);
        ArgumentNullException.ThrowIfNull(snapshot);

        if (clear)
            provider.Clear();

        foreach (var table in snapshot.Tables)
        {
            var columns = table.Columns?.Select(column => new ColumnInfo(
                column.Name,
                DataType: column.DataType)).ToArray() ?? [];

            provider.AddTable(new TableInfo(
                table.Name,
                table.Schema,
                table.Database,
                Columns: columns,
                IsView: table.IsView));
        }

        provider.BumpMetadataEpoch();
    }
}
