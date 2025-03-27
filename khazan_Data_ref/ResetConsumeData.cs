using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class ResetConsumeData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int ConsumeTIDX { get; set; }
    public long ResetCount { get; set; }
}

public class ResetConsumeDataTbl : KhazanTableBase
{
    public List<ResetConsumeData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<ResetConsumeData>();
        var dataArray = array.ToObject<ResetConsumeData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
