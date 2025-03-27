using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SpecialShopData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EMenuAbilityType SpecialShopType { get; set; }
    public int ShopItemGroup { get; set; }
    public int RandomItemCount { get; set; }
}

public class SpecialShopDataTbl : KhazanTableBase
{
    public List<SpecialShopData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SpecialShopData>();
        var dataArray = array.ToObject<SpecialShopData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
