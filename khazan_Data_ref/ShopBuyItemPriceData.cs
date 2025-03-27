using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopBuyItemPriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int EquipmentTIDX { get; set; }
    public int ConsumeTIDX { get; set; }
    public int PriceGold { get; set; }
    public int PriceLacrima { get; set; }
}

public class ShopBuyItemPriceDataTbl : KhazanTableBase
{
    public List<ShopBuyItemPriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopBuyItemPriceData>();
        var dataArray = array.ToObject<ShopBuyItemPriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
