using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BalanceTrainingMonsterLevelData : KhazanDataBase
{
    public int TIDX { get; set; }
    public long ClearedMissionTIDX { get; set; }
    public int[] CombatLevel_Playground { get; set; }
}

public class BalanceTrainingMonsterLevelDataTbl : KhazanTableBase
{
    public List<BalanceTrainingMonsterLevelData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BalanceTrainingMonsterLevelData>();
        var dataArray = array.ToObject<BalanceTrainingMonsterLevelData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
