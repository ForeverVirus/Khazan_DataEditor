using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class skilldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Path { get; set; }
public PropertyData Path_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class skilldatatbl : KhazanTableBase
{
    public List<skilldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<skilldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<skilldata>();
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
