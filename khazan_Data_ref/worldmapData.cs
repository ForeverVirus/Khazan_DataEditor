using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class worldmapData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int WorldMapGroupIDX { get; set; }
    public string Name { get; set; }
    public int MissionGroupIDX { get; set; }
    public bool AreaFirstMission { get; set; }
    public int SoulStoneCount { get; set; }
    public int DanjinCount { get; set; }
    public string BeforeUnlockFunctionDesc { get; set; }
    public string AfterUnlockFunctionDesc { get; set; }
    public string UnlockFunctionImage { get; set; }
    public string NpcDesc { get; set; }
    public string NpcImagePath { get; set; }
    public string SubMissionButtonImagePath { get; set; }
}

public class worldmapDataTbl : KhazanTableBase
{
    public List<worldmapData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<worldmapData>();
        var dataArray = array.ToObject<worldmapData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
