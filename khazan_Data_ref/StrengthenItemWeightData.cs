using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class StrengthenItemWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int LevelGap { get; set; }
    public EItemGrade OriginGrade { get; set; }
    public EItemGrade MaterialGrade { get; set; }
    public int PriceRatio { get; set; }
    public int StrengthenLevel { get; set; }
}

public class StrengthenItemWeightDataTbl : KhazanTableBase
{
    public List<StrengthenItemWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<StrengthenItemWeightData>();
        var dataArray = array.ToObject<StrengthenItemWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
