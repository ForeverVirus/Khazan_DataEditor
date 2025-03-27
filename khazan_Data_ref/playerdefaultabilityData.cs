using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class playerdefaultabilityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EGrBaseStatus DefaultStat { get; set; }
    public int Level { get; set; }
    public Status Status { get; set; }
}

public class playerdefaultabilityDataTbl : KhazanTableBase
{
    public List<playerdefaultabilityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<playerdefaultabilityData>();
        var dataArray = array.ToObject<playerdefaultabilityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
