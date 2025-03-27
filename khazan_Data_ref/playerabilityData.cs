using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class playerabilityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Desc { get; set; }
    public int GroupIndex { get; set; }
    public int Level { get; set; }
    public Status Status { get; set; }
}

public class playerabilityDataTbl : KhazanTableBase
{
    public List<playerabilityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<playerabilityData>();
        var dataArray = array.ToObject<playerabilityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
