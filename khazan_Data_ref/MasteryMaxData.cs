using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MasteryMaxData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemGrade Grade { get; set; }
    public int MasteryValue { get; set; }
}

public class MasteryMaxDataTbl : KhazanTableBase
{
    public List<MasteryMaxData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MasteryMaxData>();
        var dataArray = array.ToObject<MasteryMaxData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
