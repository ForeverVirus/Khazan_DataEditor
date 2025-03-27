using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class PassiveSkillOptionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupID { get; set; }
    public int SkillLevel { get; set; }
    public string InherentStat1Name { get; set; }
    public int InherentOption1TIDX { get; set; }
}

public class PassiveSkillOptionDataTbl : KhazanTableBase
{
    public List<PassiveSkillOptionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<PassiveSkillOptionData>();
        var dataArray = array.ToObject<PassiveSkillOptionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
