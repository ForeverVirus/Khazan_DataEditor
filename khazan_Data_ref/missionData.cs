using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EMissionType MissionType { get; set; }
public PropertyData MissionType_Property { get; set; }
    public int UnLockMissionTIDX { get; set; }
public PropertyData UnLockMissionTIDX_Property { get; set; }
    public int UnlockNpcDialogue { get; set; }
public PropertyData UnlockNpcDialogue_Property { get; set; }
    public int UnlockPlayerLevel { get; set; }
public PropertyData UnlockPlayerLevel_Property { get; set; }
    public int MissionZoneInfoTIDX { get; set; }
public PropertyData MissionZoneInfoTIDX_Property { get; set; }
    public int MissionPlayRoundLevel_01 { get; set; }
public PropertyData MissionPlayRoundLevel_01_Property { get; set; }
    public int MissionPlayRoundLevel_02 { get; set; }
public PropertyData MissionPlayRoundLevel_02_Property { get; set; }
    public int MissionPlayRoundLevel_03 { get; set; }
public PropertyData MissionPlayRoundLevel_03_Property { get; set; }
    public int MissionPlayRoundLevel_04 { get; set; }
public PropertyData MissionPlayRoundLevel_04_Property { get; set; }
    public int MissionPlayRoundLevel_05 { get; set; }
public PropertyData MissionPlayRoundLevel_05_Property { get; set; }
    public string AreaName { get; set; }
public PropertyData AreaName_Property { get; set; }
    public string MissionName { get; set; }
public PropertyData MissionName_Property { get; set; }
    public string MissionGoal { get; set; }
public PropertyData MissionGoal_Property { get; set; }
    public string MissionStartDesc { get; set; }
public PropertyData MissionStartDesc_Property { get; set; }
    public string LoadingImgPath { get; set; }
public PropertyData LoadingImgPath_Property { get; set; }
    public string LoadingMoviePath { get; set; }
public PropertyData LoadingMoviePath_Property { get; set; }
    public string LoadingDesc { get; set; }
public PropertyData LoadingDesc_Property { get; set; }
    public string MissionEndDesc { get; set; }
public PropertyData MissionEndDesc_Property { get; set; }
    public string EndNpcName { get; set; }
public PropertyData EndNpcName_Property { get; set; }
    public string EndNpcImgPath { get; set; }
public PropertyData EndNpcImgPath_Property { get; set; }
    public string SaveLoadImgPath { get; set; }
public PropertyData SaveLoadImgPath_Property { get; set; }
    public string AreaImage { get; set; }
public PropertyData AreaImage_Property { get; set; }
    public int DestructibleDropID { get; set; }
public PropertyData DestructibleDropID_Property { get; set; }
    public int NextTIDX { get; set; }
public PropertyData NextTIDX_Property { get; set; }
    public ECreviceWorldState CreviceWorldState { get; set; }
public PropertyData CreviceWorldState_Property { get; set; }
    public int[] TombStoneTIDX { get; set; }
public PropertyData TombStoneTIDX_Property { get; set; }
    public int UnLockPhantomIndex { get; set; }
public PropertyData UnLockPhantomIndex_Property { get; set; }
    public string StrongEnemySpell { get; set; }
public PropertyData StrongEnemySpell_Property { get; set; }
}

public class missiondatatbl : KhazanTableBase
{
    public List<missiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missiondata>();
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
