using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class WeaponSkillOptionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupID { get; set; }
    public int SkillLevel { get; set; }
    public string StatName { get; set; }
    public int OptionTIDX { get; set; }
}

public class WeaponSkillOptionDataTbl : KhazanTableBase
{
    public List<WeaponSkillOptionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<WeaponSkillOptionData>();
        var dataArray = array.ToObject<WeaponSkillOptionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
