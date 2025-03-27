using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class reforgelevelweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MinLevel { get; set; }
public PropertyData MinLevel_Property { get; set; }
    public int MaxLevel { get; set; }
public PropertyData MaxLevel_Property { get; set; }
    public long GoldWeight { get; set; }
public PropertyData GoldWeight_Property { get; set; }
    public long LacrimaWeight { get; set; }
public PropertyData LacrimaWeight_Property { get; set; }
    public long Material1Weight { get; set; }
public PropertyData Material1Weight_Property { get; set; }
    public long Material2Weight { get; set; }
public PropertyData Material2Weight_Property { get; set; }
    public long Material3Weight { get; set; }
public PropertyData Material3Weight_Property { get; set; }
    public long Material4Weight { get; set; }
public PropertyData Material4Weight_Property { get; set; }
}

public class reforgelevelweightdatatbl : KhazanTableBase
{
    public List<reforgelevelweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<reforgelevelweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<reforgelevelweightdata>();
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
