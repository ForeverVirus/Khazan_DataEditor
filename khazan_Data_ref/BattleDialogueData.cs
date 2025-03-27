using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class BattleDialogueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public bool IsLinkedSpawnHandler { get; set; }
    public int MissionGoalTIDX { get; set; }
    public int MonsterTIDX { get; set; }
    public EBattleDialogueConditionType DialogueCondition { get; set; }
    public int ConditionValue1 { get; set; }
    public string ConditionValue2 { get; set; }
    public bool IsShowWhenRevive { get; set; }
    public int DialogueProb { get; set; }
    public int DialogueMaxCount { get; set; }
    public EBattleDialogueOrderType DialogueOrderType { get; set; }
    public int[] SequenceDialogueTIDX { get; set; }
}

public class BattleDialogueDataTbl : KhazanTableBase
{
    public List<BattleDialogueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<BattleDialogueData>();
        var dataArray = array.ToObject<BattleDialogueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
