using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipbasestatdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long WeaponBaseStatMin { get; set; }
public PropertyData WeaponBaseStatMin_Property { get; set; }
    public long WeaponBaseStatMax { get; set; }
public PropertyData WeaponBaseStatMax_Property { get; set; }
    public long Armor_SheetingBaseStatMin { get; set; }
public PropertyData Armor_SheetingBaseStatMin_Property { get; set; }
    public long Armor_SheetingBaseStatMax { get; set; }
public PropertyData Armor_SheetingBaseStatMax_Property { get; set; }
    public long Armor_HeavyBaseStatMin { get; set; }
public PropertyData Armor_HeavyBaseStatMin_Property { get; set; }
    public long Armor_HeavyBaseStatMax { get; set; }
public PropertyData Armor_HeavyBaseStatMax_Property { get; set; }
    public long Armor_GreavesBaseStatMin { get; set; }
public PropertyData Armor_GreavesBaseStatMin_Property { get; set; }
    public long Armor_GreavesBaseStatMax { get; set; }
public PropertyData Armor_GreavesBaseStatMax_Property { get; set; }
    public long AccessoryBaseStatMin { get; set; }
public PropertyData AccessoryBaseStatMin_Property { get; set; }
    public long AccessoryBaseStatMax { get; set; }
public PropertyData AccessoryBaseStatMax_Property { get; set; }
}

public class equipbasestatdatatbl : KhazanTableBase
{
    public List<equipbasestatdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipbasestatdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipbasestatdata>();
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
