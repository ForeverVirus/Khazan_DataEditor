using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ShopSellItemPriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public string Class { get; set; }
    public string SubClass { get; set; }
    public int EquipmentTIDX { get; set; }
    public int ConsumeTIDX { get; set; }
    public int Price { get; set; }
}

public class ShopSellItemPriceDataTbl : KhazanTableBase
{
    public List<ShopSellItemPriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ShopSellItemPriceData>();
        var dataArray = array.ToObject<ShopSellItemPriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
