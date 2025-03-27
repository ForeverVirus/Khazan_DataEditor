using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class specialshopdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EMenuAbilityType SpecialShopType { get; set; }
public PropertyData SpecialShopType_Property { get; set; }
    public int ShopItemGroup { get; set; }
public PropertyData ShopItemGroup_Property { get; set; }
    public int RandomItemCount { get; set; }
public PropertyData RandomItemCount_Property { get; set; }
}

public class specialshopdatatbl : KhazanTableBase
{
    public List<specialshopdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<specialshopdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<specialshopdata>();
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
