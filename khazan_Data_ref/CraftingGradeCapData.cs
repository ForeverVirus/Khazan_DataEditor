using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingGradeCapData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int Playround { get; set; }
    public int MissionTIDX { get; set; }
    public EItemGrade MaximumLimitGrade { get; set; }
}

public class CraftingGradeCapDataTbl : KhazanTableBase
{
    public List<CraftingGradeCapData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingGradeCapData>();
        var dataArray = array.ToObject<CraftingGradeCapData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
