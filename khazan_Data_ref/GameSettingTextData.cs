using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class GameSettingTextData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Desc { get; set; }
    public string ContentType { get; set; }
    public string Format { get; set; }
}

public class GameSettingTextDataTbl : KhazanTableBase
{
    public List<GameSettingTextData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<GameSettingTextData>();
        var dataArray = array.ToObject<GameSettingTextData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
