using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class resetconsumedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int ConsumeTIDX { get; set; }
public PropertyData ConsumeTIDX_Property { get; set; }
    public long ResetCount { get; set; }
public PropertyData ResetCount_Property { get; set; }
}

public class resetconsumedatatbl : KhazanTableBase
{
    public List<resetconsumedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<resetconsumedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<resetconsumedata>();
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
