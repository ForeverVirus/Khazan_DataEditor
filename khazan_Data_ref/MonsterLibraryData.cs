using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MonsterLibraryData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int[] MonsterTIDX { get; set; }
    public string MonsterDisplayName { get; set; }
    public bool Trainable { get; set; }
    public EMonsterLibraryGrade MonsterGrade { get; set; }
    public string MonsterImgPath { get; set; }
    public string MonsterNameDesc { get; set; }
    public string MonsterDesc1 { get; set; }
    public string MonsterDesc2 { get; set; }
    public EMonsterLibraryGoal Goal2 { get; set; }
    public string Goal2DisplayText { get; set; }
    public int Goal2Value { get; set; }
    public bool Goal2Accumulate { get; set; }
    public string MonsterDesc3 { get; set; }
    public EMonsterLibraryGoal Goal3 { get; set; }
    public string Goal3DisplayText { get; set; }
    public int Goal3Value { get; set; }
    public bool Goal3Accumulate { get; set; }
    public ERewardType RewardType { get; set; }
    public long RewardTIDX { get; set; }
    public int RewardLevel { get; set; }
    public EItemGrade RewardGrade { get; set; }
    public int RewardCount { get; set; }
}

public class MonsterLibraryDataTbl : KhazanTableBase
{
    public List<MonsterLibraryData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MonsterLibraryData>();
        var dataArray = array.ToObject<MonsterLibraryData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
