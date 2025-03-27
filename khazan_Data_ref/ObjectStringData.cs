using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ObjectStringData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string InteractionText { get; set; }
}

public class ObjectStringDataTbl : KhazanTableBase
{
    public List<ObjectStringData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ObjectStringData>();
        var dataArray = array.ToObject<ObjectStringData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
