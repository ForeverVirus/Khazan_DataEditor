using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class StatusEffectData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Path { get; set; }
    public string Description { get; set; }
}

public class StatusEffectDataTbl : KhazanTableBase
{
    public List<StatusEffectData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<StatusEffectData>();
        var dataArray = array.ToObject<StatusEffectData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
