using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ItemRefillData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int ItemRefillGroup { get; set; }
    public string ItemRefillDesc { get; set; }
    public int Consume { get; set; }
}

public class ItemRefillDataTbl : KhazanTableBase
{
    public List<ItemRefillData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ItemRefillData>();
        var dataArray = array.ToObject<ItemRefillData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
