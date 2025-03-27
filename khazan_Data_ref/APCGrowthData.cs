using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class apcgrowthdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EAPCGrowthType GrowthType { get; set; }
public PropertyData GrowthType_Property { get; set; }
    public string SpellText { get; set; }
public PropertyData SpellText_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public long RequireItemTIDX { get; set; }
public PropertyData RequireItemTIDX_Property { get; set; }
    public int RequireCount { get; set; }
public PropertyData RequireCount_Property { get; set; }
    public int BalanceOptionInfoTIDX { get; set; }
public PropertyData BalanceOptionInfoTIDX_Property { get; set; }
    public string IconPath { get; set; }
public PropertyData IconPath_Property { get; set; }
}

public class apcgrowthdatatbl : KhazanTableBase
{
    public List<apcgrowthdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<apcgrowthdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<apcgrowthdata>();
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
