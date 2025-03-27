using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class RewardItemInfo : KhazanDataBase
{
    public int DropRewardTIDX { get; set; }
public PropertyData DropRewardTIDX_Property { get; set; }
    public int DropRewardItemLevel { get; set; }
public PropertyData DropRewardItemLevel_Property { get; set; }
}

public class npcdialoguerewarditemdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public RewardItemInfo[] RewardItemInfo { get; set; }
public PropertyData RewardItemInfo_Property { get; set; }
}

public class npcdialoguerewarditemdatatbl : KhazanTableBase
{
    public List<npcdialoguerewarditemdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<npcdialoguerewarditemdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<npcdialoguerewarditemdata>();
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
