using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class DecomposeGradeWeightData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemGrade Grade { get; set; }
    public int ExpWeight { get; set; }
    public int[] MaterialCountWeight { get; set; }
}

public class DecomposeGradeWeightDataTbl : KhazanTableBase
{
    public List<DecomposeGradeWeightData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<DecomposeGradeWeightData>();
        var dataArray = array.ToObject<DecomposeGradeWeightData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
