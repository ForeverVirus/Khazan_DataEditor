using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class transfermaterialData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemType Type { get; set; }
    public EItemSubType SubType { get; set; }
    public EItemGrade Grade { get; set; }
    public EItemGrade GradeCondition { get; set; }
    public int GoldCost { get; set; }
    public int[] MaterialTIDX { get; set; }
    public int[] MaterialCount { get; set; }
}

public class transfermaterialDataTbl : KhazanTableBase
{
    public List<transfermaterialData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<transfermaterialData>();
        var dataArray = array.ToObject<transfermaterialData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
