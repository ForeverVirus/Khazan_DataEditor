using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ItemOptionTextData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public EGrBaseStatus StatID { get; set; }
    public EItemOptionCondition Condition1ID { get; set; }
    public int Condition1Value { get; set; }
    public EDyanmicOptionApplyType Condition1ApplyType { get; set; }
    public EItemOptionCondition Condition2ID { get; set; }
    public int Condition2Value { get; set; }
    public EDyanmicOptionApplyType Condition2ApplyType { get; set; }
    public int MinValue { get; set; }
    public int MaxValue { get; set; }
    public int StatusEffect { get; set; }
    public int SkillName { get; set; }
    public int SkillLevel { get; set; }
    public string ValueText { get; set; }
    public string ConditionTag { get; set; }
    public bool bDisplayEncyclopedia { get; set; }
    public int DisplayEncyclopediaNeedMissionTIDX { get; set; }
    public int[] ItemAddInfoTIDX { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ItemOptionTextDataTbl : KhazanTableBase
{
    public List<ItemOptionTextData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ItemOptionTextData>();
        var dataArray = array.ToObject<ItemOptionTextData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
