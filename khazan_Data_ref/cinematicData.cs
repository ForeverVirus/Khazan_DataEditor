using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class cinematicData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string SequenceName { get; set; }
    public string AudioEventName_Begin { get; set; }
    public string AudioEventName_End { get; set; }
}

public class cinematicDataTbl : KhazanTableBase
{
    public List<cinematicData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<cinematicData>();
        var dataArray = array.ToObject<cinematicData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
