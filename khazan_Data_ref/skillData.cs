using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class skillData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Path { get; set; }
    public string Description { get; set; }
}

public class skillDataTbl : KhazanTableBase
{
    public List<skillData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<skillData>();
        var dataArray = array.ToObject<skillData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
