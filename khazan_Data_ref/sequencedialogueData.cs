using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class sequencedialogueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Speaker { get; set; }
    public string SpeakerStyleName { get; set; }
    public string Dialogue { get; set; }
    public long ConnectSpawnIDX { get; set; }
    public string OVRLipsyncAssetPath { get; set; }
}

public class sequencedialogueDataTbl : KhazanTableBase
{
    public List<sequencedialogueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<sequencedialogueData>();
        var dataArray = array.ToObject<sequencedialogueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
