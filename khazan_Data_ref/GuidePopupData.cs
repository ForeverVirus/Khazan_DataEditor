using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class guidepopupdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public string Title { get; set; }
public PropertyData Title_Property { get; set; }
    public string Content { get; set; }
public PropertyData Content_Property { get; set; }
}

public class guidepopupdatatbl : KhazanTableBase
{
    public List<guidepopupdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<guidepopupdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<guidepopupdata>();
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
