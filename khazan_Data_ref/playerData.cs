using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class playerData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public string Blueprint { get; set; }
    public int BasicLevel { get; set; }
    public int AbilityGroupIndex { get; set; }
    public string SkillListInfo { get; set; }
}

public class playerDataTbl : KhazanTableBase
{
    public List<playerData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<playerData>();
        var dataArray = array.ToObject<playerData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
