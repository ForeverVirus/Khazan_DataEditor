using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class reforgecountweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int ChangeCount { get; set; }
public PropertyData ChangeCount_Property { get; set; }
    public int GoldWeight { get; set; }
public PropertyData GoldWeight_Property { get; set; }
    public int LacrimaWeight { get; set; }
public PropertyData LacrimaWeight_Property { get; set; }
    public int Material1Weight { get; set; }
public PropertyData Material1Weight_Property { get; set; }
    public int Material2Weight { get; set; }
public PropertyData Material2Weight_Property { get; set; }
    public int Material3Weight { get; set; }
public PropertyData Material3Weight_Property { get; set; }
    public int Material4Weight { get; set; }
public PropertyData Material4Weight_Property { get; set; }
}

public class reforgecountweightdatatbl : KhazanTableBase
{
    public List<reforgecountweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<reforgecountweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<reforgecountweightdata>();
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
