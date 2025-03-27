using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class missionrecordindexData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public int MissionGroupTIDX { get; set; }
    public int RecordGroupID { get; set; }
    public int ObjectiveMissionTIDX { get; set; }
    public int RevengePoint { get; set; }
    public string ButtonImagePath { get; set; }
}

public class missionrecordindexDataTbl : KhazanTableBase
{
    public List<missionrecordindexData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<missionrecordindexData>();
        var dataArray = array.ToObject<missionrecordindexData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
