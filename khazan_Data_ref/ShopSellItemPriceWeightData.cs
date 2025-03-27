using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopsellitempriceweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long MinLevel { get; set; }
public PropertyData MinLevel_Property { get; set; }
    public long MaxLevel { get; set; }
public PropertyData MaxLevel_Property { get; set; }
    public float Weight { get; set; }
public PropertyData Weight_Property { get; set; }
}

public class shopsellitempriceweightdatatbl : KhazanTableBase
{
    public List<shopsellitempriceweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopsellitempriceweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopsellitempriceweightdata>();
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
