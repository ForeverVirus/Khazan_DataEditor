using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class localizetextdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public string Text { get; set; }
public PropertyData Text_Property { get; set; }
}

public class localizetextdatatbl : KhazanTableBase
{
    public List<localizetextdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<localizetextdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<localizetextdata>();
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
