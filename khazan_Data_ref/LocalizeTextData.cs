using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class LocalizeTextData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Desc { get; set; }
    public string Text { get; set; }
}

public class LocalizeTextDataTbl : KhazanTableBase
{
    public List<LocalizeTextData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<LocalizeTextData>();
        var dataArray = array.ToObject<LocalizeTextData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
