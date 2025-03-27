using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancepricedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupID { get; set; }
public PropertyData GroupID_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public int RewardLv { get; set; }
public PropertyData RewardLv_Property { get; set; }
    public int BuyGold { get; set; }
public PropertyData BuyGold_Property { get; set; }
    public int SellGold { get; set; }
public PropertyData SellGold_Property { get; set; }
    public int CraftGold { get; set; }
public PropertyData CraftGold_Property { get; set; }
    public int SellExp { get; set; }
public PropertyData SellExp_Property { get; set; }
}

public class balancepricedatatbl : KhazanTableBase
{
    public List<balancepricedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancepricedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancepricedata>();
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
