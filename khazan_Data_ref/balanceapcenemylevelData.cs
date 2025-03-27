using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balanceapcenemyleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int PlayerClearMissionTIDX { get; set; }
public PropertyData PlayerClearMissionTIDX_Property { get; set; }
    public ERewardGrade MonsterRewardGrade { get; set; }
public PropertyData MonsterRewardGrade_Property { get; set; }
    public int Playround { get; set; }
public PropertyData Playround_Property { get; set; }
    public bool SmartDropLevel { get; set; }
public PropertyData SmartDropLevel_Property { get; set; }
    public int SmartDropAddLevel { get; set; }
public PropertyData SmartDropAddLevel_Property { get; set; }
    public int RewardLevelMin { get; set; }
public PropertyData RewardLevelMin_Property { get; set; }
    public int RewardLevelMax { get; set; }
public PropertyData RewardLevelMax_Property { get; set; }
    public int GoodsRewardLevel { get; set; }
public PropertyData GoodsRewardLevel_Property { get; set; }
    public int CombatLevel { get; set; }
public PropertyData CombatLevel_Property { get; set; }
    public int DropRewardTIDX { get; set; }
public PropertyData DropRewardTIDX_Property { get; set; }
    public int FirstKillDropRewardTIDX { get; set; }
public PropertyData FirstKillDropRewardTIDX_Property { get; set; }
}

public class balanceapcenemyleveldatatbl : KhazanTableBase
{
    public List<balanceapcenemyleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balanceapcenemyleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balanceapcenemyleveldata>();
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
