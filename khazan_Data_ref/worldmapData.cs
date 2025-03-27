using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class worldmapdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int WorldMapGroupIDX { get; set; }
public PropertyData WorldMapGroupIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int MissionGroupIDX { get; set; }
public PropertyData MissionGroupIDX_Property { get; set; }
    public bool AreaFirstMission { get; set; }
public PropertyData AreaFirstMission_Property { get; set; }
    public int SoulStoneCount { get; set; }
public PropertyData SoulStoneCount_Property { get; set; }
    public int DanjinCount { get; set; }
public PropertyData DanjinCount_Property { get; set; }
    public string BeforeUnlockFunctionDesc { get; set; }
public PropertyData BeforeUnlockFunctionDesc_Property { get; set; }
    public string AfterUnlockFunctionDesc { get; set; }
public PropertyData AfterUnlockFunctionDesc_Property { get; set; }
    public string UnlockFunctionImage { get; set; }
public PropertyData UnlockFunctionImage_Property { get; set; }
    public string NpcDesc { get; set; }
public PropertyData NpcDesc_Property { get; set; }
    public string NpcImagePath { get; set; }
public PropertyData NpcImagePath_Property { get; set; }
    public string SubMissionButtonImagePath { get; set; }
public PropertyData SubMissionButtonImagePath_Property { get; set; }
}

public class worldmapdatatbl : KhazanTableBase
{
    public List<worldmapdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<worldmapdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<worldmapdata>();
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
