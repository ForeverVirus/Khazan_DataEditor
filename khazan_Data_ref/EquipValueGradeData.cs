using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class EquipValueGradeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public int Value { get; set; }
    public int WeightValue { get; set; }
}

public class EquipValueGradeDataTbl : KhazanTableBase
{
    public List<EquipValueGradeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<EquipValueGradeData>();
        var dataArray = array.ToObject<EquipValueGradeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
