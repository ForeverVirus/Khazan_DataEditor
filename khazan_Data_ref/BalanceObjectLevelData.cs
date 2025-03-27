using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceObjectLevelData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int MissionTidx { get; set; }
    public int UniqueIndex { get; set; }
    public int[] ContentsLevel_Playround { get; set; }
    public string Description { get; set; }
}

public class BalanceObjectLevelDataTbl : KhazanTableBase
{
    public List<BalanceObjectLevelData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceObjectLevelData>();
        var dataArray = array.ToObject<BalanceObjectLevelData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
