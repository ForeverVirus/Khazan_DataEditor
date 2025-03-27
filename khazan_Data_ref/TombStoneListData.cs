using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class tombstonelistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public bool IsStartingPoint { get; set; }
public PropertyData IsStartingPoint_Property { get; set; }
    public string ImagePath { get; set; }
public PropertyData ImagePath_Property { get; set; }
}

public class tombstonelistdatatbl : KhazanTableBase
{
    public List<tombstonelistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<tombstonelistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<tombstonelistdata>();
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
