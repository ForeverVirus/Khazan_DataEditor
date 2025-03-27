using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceMissionLevelCategoryData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int MissionTIDX { get; set; }
    public ERewardGrade MonsterRewardGrade { get; set; }
    public int Playround { get; set; }
    public int BalanceGroup { get; set; }
    public bool SmartDropLevel { get; set; }
    public int SmartDropAddLevel { get; set; }
    public int RewardLevelMin { get; set; }
    public int RewardLevelMax { get; set; }
    public int GoodsRewardLevel { get; set; }
    public int CombatLevel { get; set; }
    public int DropRewardTIDX { get; set; }
    public int FirstKill_DropRewardTIDX { get; set; }
}

public class BalanceMissionLevelCategoryDataTbl : KhazanTableBase
{
    public List<BalanceMissionLevelCategoryData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceMissionLevelCategoryData>();
        var dataArray = array.ToObject<BalanceMissionLevelCategoryData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
