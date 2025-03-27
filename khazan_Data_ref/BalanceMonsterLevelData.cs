using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceMonsterLevelData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long MissionTidx { get; set; }
    public long UniqueIndex { get; set; }
    public int[] ContentsLevel_Playround { get; set; }
    public string Description { get; set; }
}

public class BalanceMonsterLevelDataTbl : KhazanTableBase
{
    public List<BalanceMonsterLevelData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceMonsterLevelData>();
        var dataArray = array.ToObject<BalanceMonsterLevelData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
