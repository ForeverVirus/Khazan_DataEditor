using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class DecomposeLevelWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MinLevel { get; set; }
    public int MaxLevel { get; set; }
    public int ExpWeight { get; set; }
    public int[] MaterialCountWeight { get; set; }
}

public class DecomposeLevelWeightDataTbl : KhazanTableBase
{
    public List<DecomposeLevelWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<DecomposeLevelWeightData>();
        var dataArray = array.ToObject<DecomposeLevelWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
