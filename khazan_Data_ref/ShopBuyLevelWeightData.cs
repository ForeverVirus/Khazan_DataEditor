using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyLevelWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long Level { get; set; }
    public int GoldWeight { get; set; }
    public int LacrimaWeight { get; set; }
}

public class ShopBuyLevelWeightDataTbl : KhazanTableBase
{
    public List<ShopBuyLevelWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyLevelWeightData>();
        var dataArray = array.ToObject<ShopBuyLevelWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
