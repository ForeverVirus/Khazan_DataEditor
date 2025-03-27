using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftinglevelweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int GoldWeight { get; set; }
public PropertyData GoldWeight_Property { get; set; }
    public int Material1Weight { get; set; }
public PropertyData Material1Weight_Property { get; set; }
    public int Material2Weight { get; set; }
public PropertyData Material2Weight_Property { get; set; }
    public int Material3Weight { get; set; }
public PropertyData Material3Weight_Property { get; set; }
    public int Material4Weight { get; set; }
public PropertyData Material4Weight_Property { get; set; }
    public int Material5Weight { get; set; }
public PropertyData Material5Weight_Property { get; set; }
    public int Material6Weight { get; set; }
public PropertyData Material6Weight_Property { get; set; }
}

public class craftinglevelweightdatatbl : KhazanTableBase
{
    public List<craftinglevelweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftinglevelweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftinglevelweightdata>();
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
