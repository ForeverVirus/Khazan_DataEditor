using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ItemRefillGroupData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string ItemRefillDesc { get; set; }
}

public class ItemRefillGroupDataTbl : KhazanTableBase
{
    public List<ItemRefillGroupData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ItemRefillGroupData>();
        var dataArray = array.ToObject<ItemRefillGroupData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
