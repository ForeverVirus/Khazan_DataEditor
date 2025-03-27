using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class reforgecountweightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int ChangeCount { get; set; }
    public int GoldWeight { get; set; }
    public int LacrimaWeight { get; set; }
    public int Material1Weight { get; set; }
    public int Material2Weight { get; set; }
    public int Material3Weight { get; set; }
    public int Material4Weight { get; set; }
}

public class reforgecountweightDataTbl : KhazanTableBase
{
    public List<reforgecountweightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<reforgecountweightData>();
        var dataArray = array.ToObject<reforgecountweightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
