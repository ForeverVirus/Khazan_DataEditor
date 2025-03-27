using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class transferlevelweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public long GoldWeight { get; set; }
public PropertyData GoldWeight_Property { get; set; }
    public long[] MaterialWeight { get; set; }
public PropertyData MaterialWeight_Property { get; set; }
}

public class transferlevelweightdatatbl : KhazanTableBase
{
    public List<transferlevelweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<transferlevelweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<transferlevelweightdata>();
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
