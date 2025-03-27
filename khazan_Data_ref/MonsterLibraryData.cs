using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class monsterlibrarydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int[] MonsterTIDX { get; set; }
public PropertyData MonsterTIDX_Property { get; set; }
    public string MonsterDisplayName { get; set; }
public PropertyData MonsterDisplayName_Property { get; set; }
    public bool Trainable { get; set; }
public PropertyData Trainable_Property { get; set; }
    public EMonsterLibraryGrade MonsterGrade { get; set; }
public PropertyData MonsterGrade_Property { get; set; }
    public string MonsterImgPath { get; set; }
public PropertyData MonsterImgPath_Property { get; set; }
    public string MonsterNameDesc { get; set; }
public PropertyData MonsterNameDesc_Property { get; set; }
    public string MonsterDesc1 { get; set; }
public PropertyData MonsterDesc1_Property { get; set; }
    public string MonsterDesc2 { get; set; }
public PropertyData MonsterDesc2_Property { get; set; }
    public EMonsterLibraryGoal Goal2 { get; set; }
public PropertyData Goal2_Property { get; set; }
    public string Goal2DisplayText { get; set; }
public PropertyData Goal2DisplayText_Property { get; set; }
    public int Goal2Value { get; set; }
public PropertyData Goal2Value_Property { get; set; }
    public bool Goal2Accumulate { get; set; }
public PropertyData Goal2Accumulate_Property { get; set; }
    public string MonsterDesc3 { get; set; }
public PropertyData MonsterDesc3_Property { get; set; }
    public EMonsterLibraryGoal Goal3 { get; set; }
public PropertyData Goal3_Property { get; set; }
    public string Goal3DisplayText { get; set; }
public PropertyData Goal3DisplayText_Property { get; set; }
    public int Goal3Value { get; set; }
public PropertyData Goal3Value_Property { get; set; }
    public bool Goal3Accumulate { get; set; }
public PropertyData Goal3Accumulate_Property { get; set; }
    public ERewardType RewardType { get; set; }
public PropertyData RewardType_Property { get; set; }
    public long RewardTIDX { get; set; }
public PropertyData RewardTIDX_Property { get; set; }
    public int RewardLevel { get; set; }
public PropertyData RewardLevel_Property { get; set; }
    public EItemGrade RewardGrade { get; set; }
public PropertyData RewardGrade_Property { get; set; }
    public int RewardCount { get; set; }
public PropertyData RewardCount_Property { get; set; }
}

public class monsterlibrarydatatbl : KhazanTableBase
{
    public List<monsterlibrarydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<monsterlibrarydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<monsterlibrarydata>();
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
