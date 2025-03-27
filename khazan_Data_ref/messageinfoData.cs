using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class messageinfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long Type { get; set; }
public PropertyData Type_Property { get; set; }
    public long SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class messageinfodatatbl : KhazanTableBase
{
    public List<messageinfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<messageinfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<messageinfodata>();
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
