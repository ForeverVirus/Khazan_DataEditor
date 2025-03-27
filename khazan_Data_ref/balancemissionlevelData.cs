using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class balancemissionlevelData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int ContentsLevel { get; set; }
    public bool SmartDropLevel { get; set; }
    public int SmartDropAddLevel { get; set; }
    public int RewardLevelMin { get; set; }
    public int RewardLevelMax { get; set; }
    public int GoodsRewardLevel { get; set; }
    public int CombatLevel { get; set; }
    public int DropRewardTIDX { get; set; }
    public int FirstKillDropRewardTIDX { get; set; }
}

public class balancemissionlevelDataTbl : KhazanTableBase
{
    public List<balancemissionlevelData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<balancemissionlevelData>();
        var dataArray = array.ToObject<balancemissionlevelData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
