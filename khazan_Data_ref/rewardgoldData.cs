using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class rewardgoldData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ERewardGold ID { get; set; }
    public int ContentsLevel { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
}

public class rewardgoldDataTbl : KhazanTableBase
{
    public List<rewardgoldData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<rewardgoldData>();
        var dataArray = array.ToObject<rewardgoldData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
