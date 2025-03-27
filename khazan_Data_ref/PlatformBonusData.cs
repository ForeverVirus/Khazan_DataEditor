using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class PlatformBonusRewardItem : KhazanDataBase
{
    public int TIDX { get; set; }
    public EPlatformBonus RewardType { get; set; }
    public long RewardTIDX { get; set; }
    public int RewardCount { get; set; }
}

public class PlatformBonusData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public string PBonusName { get; set; }
    public PlatformBonusRewardItem[] PlatformBonusRewardItem { get; set; }
}

public class PlatformBonusDataTbl : KhazanTableBase
{
    public List<PlatformBonusData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<PlatformBonusData>();
        var dataArray = array.ToObject<PlatformBonusData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
