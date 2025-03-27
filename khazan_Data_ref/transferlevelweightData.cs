using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class transferlevelweightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public long GoldWeight { get; set; }
    public long[] MaterialWeight { get; set; }
}

public class transferlevelweightDataTbl : KhazanTableBase
{
    public List<transferlevelweightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<transferlevelweightData>();
        var dataArray = array.ToObject<transferlevelweightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
