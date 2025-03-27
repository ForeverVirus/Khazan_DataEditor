using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyListData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long ItemID { get; set; }
    public EItemType ItemType { get; set; }
    public bool IsRandom { get; set; }
    public int UnlockLevel { get; set; }
    public int UnlockMissionTIDX { get; set; }
    public int BuyCountMinOnlyConsume { get; set; }
    public int BuyCountMaxOnlyConsume { get; set; }
    public EPriceType PriceType { get; set; }
    public long PriceWeight { get; set; }
    public long PriceItemTIDX { get; set; }
    public int PriceItemCount { get; set; }
}

public class ShopBuyListDataTbl : KhazanTableBase
{
    public List<ShopBuyListData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyListData>();
        var dataArray = array.ToObject<ShopBuyListData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
