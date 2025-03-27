using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class PlayerStatSettingsData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public EGrBaseStatus Stat { get; set; }
    public EItemOptionValue DisplayValueType { get; set; }
}

public class PlayerStatSettingsDataTbl : KhazanTableBase
{
    public List<PlayerStatSettingsData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<PlayerStatSettingsData>();
        var dataArray = array.ToObject<PlayerStatSettingsData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
