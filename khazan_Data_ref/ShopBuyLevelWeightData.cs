using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopbuylevelweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int GoldWeight { get; set; }
public PropertyData GoldWeight_Property { get; set; }
    public int LacrimaWeight { get; set; }
public PropertyData LacrimaWeight_Property { get; set; }
}

public class shopbuylevelweightdatatbl : KhazanTableBase
{
    public List<shopbuylevelweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopbuylevelweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopbuylevelweightdata>();
        var dataExp = uasset.Exports[0] as DataTableExport;
        var table = dataExp?.Table;
        ProcessUAssetTable(table.Data, ref _table);
    }
    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
