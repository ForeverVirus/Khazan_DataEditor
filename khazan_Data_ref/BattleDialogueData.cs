using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class battledialoguedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public bool IsLinkedSpawnHandler { get; set; }
public PropertyData IsLinkedSpawnHandler_Property { get; set; }
    public int MissionGoalTIDX { get; set; }
public PropertyData MissionGoalTIDX_Property { get; set; }
    public int MonsterTIDX { get; set; }
public PropertyData MonsterTIDX_Property { get; set; }
    public EBattleDialogueConditionType DialogueCondition { get; set; }
public PropertyData DialogueCondition_Property { get; set; }
    public int ConditionValue1 { get; set; }
public PropertyData ConditionValue1_Property { get; set; }
    public string ConditionValue2 { get; set; }
public PropertyData ConditionValue2_Property { get; set; }
    public bool IsShowWhenRevive { get; set; }
public PropertyData IsShowWhenRevive_Property { get; set; }
    public int DialogueProb { get; set; }
public PropertyData DialogueProb_Property { get; set; }
    public int DialogueMaxCount { get; set; }
public PropertyData DialogueMaxCount_Property { get; set; }
    public EBattleDialogueOrderType DialogueOrderType { get; set; }
public PropertyData DialogueOrderType_Property { get; set; }
    public int[] SequenceDialogueTIDX { get; set; }
public PropertyData SequenceDialogueTIDX_Property { get; set; }
}

public class battledialoguedatatbl : KhazanTableBase
{
    public List<battledialoguedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<battledialoguedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<battledialoguedata>();
        var dataExp = uasset.Exports[0] as DataTableExport;
        var table = dataExp?.Table;
        ProcessUAssetTable(table.Data, ref _table);
    }
    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
