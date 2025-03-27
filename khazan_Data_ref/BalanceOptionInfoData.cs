using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceOptionInfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public EGrBaseStatus StatID { get; set; }
    public int StatValue { get; set; }
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
}

public class BalanceOptionInfoDataTbl : KhazanTableBase
{
    public List<BalanceOptionInfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceOptionInfoData>();
        var dataArray = array.ToObject<BalanceOptionInfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
