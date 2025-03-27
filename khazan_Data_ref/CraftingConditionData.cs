using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftingconditiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int PCLevel { get; set; }
public PropertyData PCLevel_Property { get; set; }
    public int ItemLevel { get; set; }
public PropertyData ItemLevel_Property { get; set; }
}

public class craftingconditiondatatbl : KhazanTableBase
{
    public List<craftingconditiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftingconditiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftingconditiondata>();
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
