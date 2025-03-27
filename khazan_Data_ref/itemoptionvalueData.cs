using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemoptionvalueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public int BlackListGroup { get; set; }
    public int Ratio { get; set; }
    public EGrBaseStatus StatID { get; set; }
    public int MinValue { get; set; }
    public int MaxValue { get; set; }
    public EItemOptionCondition Condition1ID { get; set; }
    public int Condition1Value { get; set; }
    public EDyanmicOptionApplyType Condition1ApplyType { get; set; }
    public EItemOptionCondition Condition2ID { get; set; }
    public int Condition2Value { get; set; }
    public EDyanmicOptionApplyType Condition2ApplyType { get; set; }
    public int StatusEffect { get; set; }
    public EStatusEffectRemoveType StatusEffectRemoveType { get; set; }
    public int SkillName { get; set; }
    public int SkillLevel { get; set; }
    public bool CanGrinding { get; set; }
    public bool CanReplace { get; set; }
    public bool CanSuccession { get; set; }
    public EOptionContentOrigin OptionOrigin { get; set; }
}

public class itemoptionvalueDataTbl : KhazanTableBase
{
    public List<itemoptionvalueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemoptionvalueData>();
        var dataArray = array.ToObject<itemoptionvalueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
