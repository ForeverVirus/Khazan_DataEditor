using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class playerstartabilityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Level { get; set; }
    public int LevelMax { get; set; }
    public int Gold { get; set; }
    public int EXP { get; set; }
    public int SkillPoint { get; set; }
    public int CommonSkillPoint { get; set; }
    public int Posion { get; set; }
}

public class playerstartabilityDataTbl : KhazanTableBase
{
    public List<playerstartabilityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<playerstartabilityData>();
        var dataArray = array.ToObject<playerstartabilityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
