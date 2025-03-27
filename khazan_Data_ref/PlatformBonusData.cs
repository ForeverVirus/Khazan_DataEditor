using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class PlatformBonusRewardItem : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EPlatformBonus RewardType { get; set; }
public PropertyData RewardType_Property { get; set; }
    public long RewardTIDX { get; set; }
public PropertyData RewardTIDX_Property { get; set; }
    public int RewardCount { get; set; }
public PropertyData RewardCount_Property { get; set; }
}

public class platformbonusdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public string PBonusName { get; set; }
public PropertyData PBonusName_Property { get; set; }
    public PlatformBonusRewardItem[] PlatformBonusRewardItem { get; set; }
public PropertyData PlatformBonusRewardItem_Property { get; set; }
}

public class platformbonusdatatbl : KhazanTableBase
{
    public List<platformbonusdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<platformbonusdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<platformbonusdata>();
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
