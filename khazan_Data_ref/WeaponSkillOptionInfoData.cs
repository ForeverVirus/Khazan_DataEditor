using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class WeaponSkillOptionInfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public EWeaponSkillStat StatID { get; set; }
    public int StatCondition { get; set; }
    public int StatValue { get; set; }
    public EWeaponSkillCondition Condition1ID { get; set; }
    public int Condition1Value { get; set; }
    public string Condition1StrValue { get; set; }
    public EWeaponSkillCondition Condition2ID { get; set; }
    public int Condition2Value { get; set; }
    public string Condition2StrValue { get; set; }
}

public class WeaponSkillOptionInfoDataTbl : KhazanTableBase
{
    public List<WeaponSkillOptionInfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<WeaponSkillOptionInfoData>();
        var dataArray = array.ToObject<WeaponSkillOptionInfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
