using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MasteryMissionLevelData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MissionTIDX { get; set; }
    public int WeaponMaxLevel_Round01 { get; set; }
    public int CommonMaxLevel_Round01 { get; set; }
    public int WeaponMaxLevel_Round02 { get; set; }
    public int CommonMaxLevel_Round02 { get; set; }
    public int WeaponMaxLevel_Round03 { get; set; }
    public int CommonMaxLevel_Round03 { get; set; }
    public int WeaponMaxLevel_Round04 { get; set; }
    public int CommonMaxLevel_Round04 { get; set; }
    public int WeaponMaxLevel_Round05 { get; set; }
    public int CommonMaxLevel_Round05 { get; set; }
}

public class MasteryMissionLevelDataTbl : KhazanTableBase
{
    public List<MasteryMissionLevelData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MasteryMissionLevelData>();
        var dataArray = array.ToObject<MasteryMissionLevelData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
