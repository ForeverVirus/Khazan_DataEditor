using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class rewardexpData : KhazanDataBase
{
    public int TIDX { get; set; }
    public ERewardContent ID { get; set; }
    public int ContentsLevel { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
}

public class rewardexpDataTbl : KhazanTableBase
{
    public List<rewardexpData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<rewardexpData>();
        var dataArray = array.ToObject<rewardexpData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
