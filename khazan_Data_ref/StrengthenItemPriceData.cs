using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class StrengthenItemPriceData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int OrginLevel { get; set; }
    public int BasePrice { get; set; }
}

public class StrengthenItemPriceDataTbl : KhazanTableBase
{
    public List<StrengthenItemPriceData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<StrengthenItemPriceData>();
        var dataArray = array.ToObject<StrengthenItemPriceData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
