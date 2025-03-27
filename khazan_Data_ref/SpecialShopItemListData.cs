using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SpecialShopItemListData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long ItemID { get; set; }
    public int ShopItemGroup { get; set; }
    public EItemType ItemType { get; set; }
    public bool IsRandom { get; set; }
    public int UnlockMissionTIDX { get; set; }
    public int UnlockJarCount { get; set; }
    public int BuyCountMaxOnlyConsume { get; set; }
    public int BuyCountMinOnlyConsume { get; set; }
    public EPriceType PriceType { get; set; }
    public long PriceWeight { get; set; }
    public long PriceItemTIDX { get; set; }
    public int PriceItemCount { get; set; }
}

public class SpecialShopItemListDataTbl : KhazanTableBase
{
    public List<SpecialShopItemListData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SpecialShopItemListData>();
        var dataArray = array.ToObject<SpecialShopItemListData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
