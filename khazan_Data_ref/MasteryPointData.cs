using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MasteryPointData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string TAG { get; set; }
    public EMasteryPoint ActionCategory { get; set; }
    public string SIDirectory { get; set; }
    public string SDDirectory { get; set; }
    public int MasteryPoint { get; set; }
    public int CommonMasteryPoint { get; set; }
}

public class MasteryPointDataTbl : KhazanTableBase
{
    public List<MasteryPointData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MasteryPointData>();
        var dataArray = array.ToObject<MasteryPointData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
