using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancemissionleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int ContentsLevel { get; set; }
public PropertyData ContentsLevel_Property { get; set; }
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

public class balancemissionleveldatatbl : KhazanTableBase
{
    public List<balancemissionleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancemissionleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancemissionleveldata>();
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
