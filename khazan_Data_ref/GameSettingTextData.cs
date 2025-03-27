using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class gamesettingtextdata : KhazanDataBase
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

public class gamesettingtextdatatbl : KhazanTableBase
{
    public List<gamesettingtextdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<gamesettingtextdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<gamesettingtextdata>();
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
