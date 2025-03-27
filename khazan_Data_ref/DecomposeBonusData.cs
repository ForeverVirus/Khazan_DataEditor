using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class RewardMaterial : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Type { get; set; }
    public int Count { get; set; }
    public int Probability { get; set; }
}

public class DecomposeBonusData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int RewardMaterialCount { get; set; }
    public RewardMaterial[] RewardMaterial { get; set; }
}

public class DecomposeBonusDataTbl : KhazanTableBase
{
    public List<DecomposeBonusData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<DecomposeBonusData>();
        var dataArray = array.ToObject<DecomposeBonusData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
