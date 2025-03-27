using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftinglistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public int ItemTIDX { get; set; }
public PropertyData ItemTIDX_Property { get; set; }
    public int ClearMissionTIDX { get; set; }
public PropertyData ClearMissionTIDX_Property { get; set; }
    public int RecipeTIDX { get; set; }
public PropertyData RecipeTIDX_Property { get; set; }
    public int PCLevel { get; set; }
public PropertyData PCLevel_Property { get; set; }
    public bool bLevelCheck { get; set; }
public PropertyData bLevelCheck_Property { get; set; }
}

public class craftinglistdatatbl : KhazanTableBase
{
    public List<craftinglistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftinglistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftinglistdata>();
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
