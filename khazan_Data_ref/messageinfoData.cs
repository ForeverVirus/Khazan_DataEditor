using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class messageinfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long Type { get; set; }
    public long SubType { get; set; }
    public string Description { get; set; }
}

public class messageinfoDataTbl : KhazanTableBase
{
    public List<messageinfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<messageinfoData>();
        var dataArray = array.ToObject<messageinfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
