using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SystemMessageData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EGameMessageType WidgetType { get; set; }
    public string Desc { get; set; }
    public string ContentType { get; set; }
    public string Format { get; set; }
    public string IconPath { get; set; }
}

public class SystemMessageDataTbl : KhazanTableBase
{
    public List<SystemMessageData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SystemMessageData>();
        var dataArray = array.ToObject<SystemMessageData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
