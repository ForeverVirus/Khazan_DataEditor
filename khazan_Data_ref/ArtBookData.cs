using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class artbookdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int PageNo { get; set; }
public PropertyData PageNo_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public string ImagePath { get; set; }
public PropertyData ImagePath_Property { get; set; }
}

public class artbookdatatbl : KhazanTableBase
{
    public List<artbookdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<artbookdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<artbookdata>();
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
