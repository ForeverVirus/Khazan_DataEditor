using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class DecomposeBonusRangeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int NextTIDX { get; set; }
    public int MaxExp { get; set; }
    public int BonusTIDX { get; set; }
}

public class DecomposeBonusRangeDataTbl : KhazanTableBase
{
    public List<DecomposeBonusRangeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<DecomposeBonusRangeData>();
        var dataArray = array.ToObject<DecomposeBonusRangeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
