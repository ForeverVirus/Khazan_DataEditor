using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class damagefloaterpriorityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EDamageFloaterEffectType EffectType { get; set; }
    public string Name { get; set; }
    public EDamageFloaterAttackType AttackType { get; set; }
    public long Priority { get; set; }
}

public class damagefloaterpriorityDataTbl : KhazanTableBase
{
    public List<damagefloaterpriorityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<damagefloaterpriorityData>();
        var dataArray = array.ToObject<damagefloaterpriorityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
