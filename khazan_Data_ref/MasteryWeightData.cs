using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MasteryWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MasteryLevelGap { get; set; }
    public int WeightValue { get; set; }
}

public class MasteryWeightDataTbl : KhazanTableBase
{
    public List<MasteryWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MasteryWeightData>();
        var dataArray = array.ToObject<MasteryWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
