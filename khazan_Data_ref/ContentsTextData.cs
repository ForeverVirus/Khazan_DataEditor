using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ContentsTextData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Desc { get; set; }
    public string ContentType { get; set; }
    public string Format { get; set; }
}

public class ContentsTextDataTbl : KhazanTableBase
{
    public List<ContentsTextData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ContentsTextData>();
        var dataArray = array.ToObject<ContentsTextData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
