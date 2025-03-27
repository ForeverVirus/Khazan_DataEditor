using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopSellItemPriceWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long MinLevel { get; set; }
    public long MaxLevel { get; set; }
    public float Weight { get; set; }
}

public class ShopSellItemPriceWeightDataTbl : KhazanTableBase
{
    public List<ShopSellItemPriceWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopSellItemPriceWeightData>();
        var dataArray = array.ToObject<ShopSellItemPriceWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
