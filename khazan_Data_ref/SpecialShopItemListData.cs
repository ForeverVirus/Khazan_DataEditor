using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class specialshopitemlistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long ItemID { get; set; }
public PropertyData ItemID_Property { get; set; }
    public int ShopItemGroup { get; set; }
public PropertyData ShopItemGroup_Property { get; set; }
    public EItemType ItemType { get; set; }
public PropertyData ItemType_Property { get; set; }
    public bool IsRandom { get; set; }
public PropertyData IsRandom_Property { get; set; }
    public int UnlockMissionTIDX { get; set; }
public PropertyData UnlockMissionTIDX_Property { get; set; }
    public int UnlockJarCount { get; set; }
public PropertyData UnlockJarCount_Property { get; set; }
    public int BuyCountMaxOnlyConsume { get; set; }
public PropertyData BuyCountMaxOnlyConsume_Property { get; set; }
    public int BuyCountMinOnlyConsume { get; set; }
public PropertyData BuyCountMinOnlyConsume_Property { get; set; }
    public EPriceType PriceType { get; set; }
public PropertyData PriceType_Property { get; set; }
    public long PriceWeight { get; set; }
public PropertyData PriceWeight_Property { get; set; }
    public long PriceItemTIDX { get; set; }
public PropertyData PriceItemTIDX_Property { get; set; }
    public int PriceItemCount { get; set; }
public PropertyData PriceItemCount_Property { get; set; }
}

public class specialshopitemlistdatatbl : KhazanTableBase
{
    public List<specialshopitemlistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<specialshopitemlistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<specialshopitemlistdata>();
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
