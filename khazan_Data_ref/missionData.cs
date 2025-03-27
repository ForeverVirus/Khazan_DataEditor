using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class missionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EMissionType MissionType { get; set; }
    public int UnLockMissionTIDX { get; set; }
    public int UnlockNpcDialogue { get; set; }
    public int UnlockPlayerLevel { get; set; }
    public int MissionZoneInfoTIDX { get; set; }
    public int MissionPlayRoundLevel_01 { get; set; }
    public int MissionPlayRoundLevel_02 { get; set; }
    public int MissionPlayRoundLevel_03 { get; set; }
    public int MissionPlayRoundLevel_04 { get; set; }
    public int MissionPlayRoundLevel_05 { get; set; }
    public string AreaName { get; set; }
    public string MissionName { get; set; }
    public string MissionGoal { get; set; }
    public string MissionStartDesc { get; set; }
    public string LoadingImgPath { get; set; }
    public string LoadingMoviePath { get; set; }
    public string LoadingDesc { get; set; }
    public string MissionEndDesc { get; set; }
    public string EndNpcName { get; set; }
    public string EndNpcImgPath { get; set; }
    public string SaveLoadImgPath { get; set; }
    public string AreaImage { get; set; }
    public int DestructibleDropID { get; set; }
    public int NextTIDX { get; set; }
    public ECreviceWorldState CreviceWorldState { get; set; }
    public int[] TombStoneTIDX { get; set; }
    public int UnLockPhantomIndex { get; set; }
    public string StrongEnemySpell { get; set; }
}

public class missionDataTbl : KhazanTableBase
{
    public List<missionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<missionData>();
        var dataArray = array.ToObject<missionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
