using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class RewardItemInfo : KhazanDataBase
{
    public int DropRewardTIDX { get; set; }
    public int DropRewardItemLevel { get; set; }
}

public class npcdialoguerewarditemData : KhazanDataBase
{
    public int TIDX { get; set; }
    public RewardItemInfo[] RewardItemInfo { get; set; }
}

public class npcdialoguerewarditemDataTbl : KhazanTableBase
{
    public List<npcdialoguerewarditemData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<npcdialoguerewarditemData>();
        var dataArray = array.ToObject<npcdialoguerewarditemData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
