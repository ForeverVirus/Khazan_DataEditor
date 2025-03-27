using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class reforgelevelweightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MinLevel { get; set; }
    public int MaxLevel { get; set; }
    public long GoldWeight { get; set; }
    public long LacrimaWeight { get; set; }
    public long Material1Weight { get; set; }
    public long Material2Weight { get; set; }
    public long Material3Weight { get; set; }
    public long Material4Weight { get; set; }
}

public class reforgelevelweightDataTbl : KhazanTableBase
{
    public List<reforgelevelweightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<reforgelevelweightData>();
        var dataArray = array.ToObject<reforgelevelweightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
