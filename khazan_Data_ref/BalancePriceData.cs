using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalancePriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupID { get; set; }
    public string Tag { get; set; }
    public int RewardLv { get; set; }
    public int BuyGold { get; set; }
    public int SellGold { get; set; }
    public int CraftGold { get; set; }
    public int SellExp { get; set; }
}

public class BalancePriceDataTbl : KhazanTableBase
{
    public List<BalancePriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalancePriceData>();
        var dataArray = array.ToObject<BalancePriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
