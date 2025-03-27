using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyConditionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int PCLevel { get; set; }
    public int ItemLevel { get; set; }
    public int GradeCommonRatio { get; set; }
    public int GradeUncommonRatio { get; set; }
    public int GradeRareRatio { get; set; }
    public int GradeUniqueRatio { get; set; }
    public int GradeLegendaryRatio { get; set; }
    public int GradeEpicRatio { get; set; }
}

public class ShopBuyConditionDataTbl : KhazanTableBase
{
    public List<ShopBuyConditionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyConditionData>();
        var dataArray = array.ToObject<ShopBuyConditionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
