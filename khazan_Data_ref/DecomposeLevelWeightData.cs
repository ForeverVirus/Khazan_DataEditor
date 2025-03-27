using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class decomposelevelweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MinLevel { get; set; }
public PropertyData MinLevel_Property { get; set; }
    public int MaxLevel { get; set; }
public PropertyData MaxLevel_Property { get; set; }
    public int ExpWeight { get; set; }
public PropertyData ExpWeight_Property { get; set; }
    public int[] MaterialCountWeight { get; set; }
public PropertyData MaterialCountWeight_Property { get; set; }
}

public class decomposelevelweightdatatbl : KhazanTableBase
{
    public List<decomposelevelweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<decomposelevelweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<decomposelevelweightdata>();
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
