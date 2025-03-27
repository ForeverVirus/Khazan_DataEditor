using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missioncharacterdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public string CharacterName { get; set; }
public PropertyData CharacterName_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public int UnlockMissionStartTDIX { get; set; }
public PropertyData UnlockMissionStartTDIX_Property { get; set; }
    public int UnlockConsumeTIDX { get; set; }
public PropertyData UnlockConsumeTIDX_Property { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
public PropertyData UnlockNPCDialogueTIDX_Property { get; set; }
    public string UnlockSequence { get; set; }
public PropertyData UnlockSequence_Property { get; set; }
    public int UnlockMissionTIDX { get; set; }
public PropertyData UnlockMissionTIDX_Property { get; set; }
    public EEndingType UnlodckEndingType { get; set; }
public PropertyData UnlodckEndingType_Property { get; set; }
    public ERelationShipType Relationship { get; set; }
public PropertyData Relationship_Property { get; set; }
    public string CharacterStory { get; set; }
public PropertyData CharacterStory_Property { get; set; }
    public string PortraitPath { get; set; }
public PropertyData PortraitPath_Property { get; set; }
    public string DetailPage_PortraitPath { get; set; }
public PropertyData DetailPage_PortraitPath_Property { get; set; }
    public int SortOrder { get; set; }
public PropertyData SortOrder_Property { get; set; }
}

public class missioncharacterdatatbl : KhazanTableBase
{
    public List<missioncharacterdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missioncharacterdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missioncharacterdata>();
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
