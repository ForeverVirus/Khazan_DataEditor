using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MetaStatCalculationData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public EOptionOrigin OptionOrigin { get; set; }
    public EOptionScoreType ScoreType { get; set; }
    public EGrBaseStatus StatID { get; set; }
    public int StatusEffect { get; set; }
    public int Skill { get; set; }
    public EItemOptionCondition Condition1ID { get; set; }
    public int Condition1Value { get; set; }
    public EItemOptionCondition Condition2ID { get; set; }
    public int Condition2Value { get; set; }
    public int MinValue { get; set; }
    public int MaxValue { get; set; }
    public float FixValue { get; set; }
}

public class MetaStatCalculationDataTbl : KhazanTableBase
{
    public List<MetaStatCalculationData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MetaStatCalculationData>();
        var dataArray = array.ToObject<MetaStatCalculationData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
