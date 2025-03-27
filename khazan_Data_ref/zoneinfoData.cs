using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class zoneinfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Area { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool TestLevel { get; set; }
    public string MusicSwitchName { get; set; }
    public EZoneType ZoneType { get; set; }
    public int UIPriority { get; set; }
    public bool PVPZone { get; set; }
    public string LevelPackageName { get; set; }
    public string SpawnLevelIdentifier { get; set; }
    public bool EnableSprintAndDash { get; set; }
    public bool EnableArmed { get; set; }
    public bool EnableBattleSkill { get; set; }
    public bool EnablePresentAreaNameOnStart { get; set; }
}

public class zoneinfoDataTbl : KhazanTableBase
{
    public List<zoneinfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<zoneinfoData>();
        var dataArray = array.ToObject<zoneinfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
