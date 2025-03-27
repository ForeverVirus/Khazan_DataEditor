using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class masterypointdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string TAG { get; set; }
public PropertyData TAG_Property { get; set; }
    public EMasteryPoint ActionCategory { get; set; }
public PropertyData ActionCategory_Property { get; set; }
    public string SIDirectory { get; set; }
public PropertyData SIDirectory_Property { get; set; }
    public string SDDirectory { get; set; }
public PropertyData SDDirectory_Property { get; set; }
    public int MasteryPoint { get; set; }
public PropertyData MasteryPoint_Property { get; set; }
    public int CommonMasteryPoint { get; set; }
public PropertyData CommonMasteryPoint_Property { get; set; }
}

public class masterypointdatatbl : KhazanTableBase
{
    public List<masterypointdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<masterypointdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<masterypointdata>();
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
