using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class contentstextdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public string ContentType { get; set; }
public PropertyData ContentType_Property { get; set; }
    public string Format { get; set; }
public PropertyData Format_Property { get; set; }
}

public class contentstextdatatbl : KhazanTableBase
{
    public List<contentstextdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<contentstextdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<contentstextdata>();
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
