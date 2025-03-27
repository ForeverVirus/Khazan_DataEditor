using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class reinforcementfailData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupIndex { get; set; }
    public EReinforceFailType ReinforceFailType { get; set; }
    public int ReduceLevel { get; set; }
    public int Weight { get; set; }
    public EReduceStatusType ReduceStatusType { get; set; }
}

public class reinforcementfailDataTbl : KhazanTableBase
{
    public List<reinforcementfailData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<reinforcementfailData>();
        var dataArray = array.ToObject<reinforcementfailData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
