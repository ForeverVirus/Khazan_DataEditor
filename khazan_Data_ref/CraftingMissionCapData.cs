using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class CraftingMissionCapData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MissionTIDX { get; set; }
    public int[] PlayRoundItemLevel { get; set; }
}

public class CraftingMissionCapDataTbl : KhazanTableBase
{
    public List<CraftingMissionCapData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<CraftingMissionCapData>();
        var dataArray = array.ToObject<CraftingMissionCapData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
