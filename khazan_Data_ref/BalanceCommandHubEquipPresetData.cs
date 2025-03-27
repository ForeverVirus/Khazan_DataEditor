using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancecommandhubequippresetdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int WeaponLevel { get; set; }
public PropertyData WeaponLevel_Property { get; set; }
    public EItemGrade WeaponGrade { get; set; }
public PropertyData WeaponGrade_Property { get; set; }
    public int ArmorLevel { get; set; }
public PropertyData ArmorLevel_Property { get; set; }
    public EItemGrade ArmorGrade { get; set; }
public PropertyData ArmorGrade_Property { get; set; }
    public int AccessoryLevel { get; set; }
public PropertyData AccessoryLevel_Property { get; set; }
    public EItemGrade AccessoryGrade { get; set; }
public PropertyData AccessoryGrade_Property { get; set; }
    public int WeaponID { get; set; }
public PropertyData WeaponID_Property { get; set; }
    public int HairID { get; set; }
public PropertyData HairID_Property { get; set; }
    public int TorsoID { get; set; }
public PropertyData TorsoID_Property { get; set; }
    public int ArmID { get; set; }
public PropertyData ArmID_Property { get; set; }
    public int LegID { get; set; }
public PropertyData LegID_Property { get; set; }
    public int ShoesID { get; set; }
public PropertyData ShoesID_Property { get; set; }
    public int NecklacesID { get; set; }
public PropertyData NecklacesID_Property { get; set; }
    public int RingID { get; set; }
public PropertyData RingID_Property { get; set; }
    public bool MaxOptionValue { get; set; }
public PropertyData MaxOptionValue_Property { get; set; }
    public long[] WeaponOptionID { get; set; }
public PropertyData WeaponOptionID_Property { get; set; }
    public long[] HairOptionID { get; set; }
public PropertyData HairOptionID_Property { get; set; }
    public long[] TorsoOptionID { get; set; }
public PropertyData TorsoOptionID_Property { get; set; }
    public long[] ArmOptionID { get; set; }
public PropertyData ArmOptionID_Property { get; set; }
    public long[] LegOptionID { get; set; }
public PropertyData LegOptionID_Property { get; set; }
    public long[] ShoesOptionID { get; set; }
public PropertyData ShoesOptionID_Property { get; set; }
    public long[] NecklacesOptionID { get; set; }
public PropertyData NecklacesOptionID_Property { get; set; }
    public long[] RingOptionID { get; set; }
public PropertyData RingOptionID_Property { get; set; }
}

public class balancecommandhubequippresetdatatbl : KhazanTableBase
{
    public List<balancecommandhubequippresetdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancecommandhubequippresetdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancecommandhubequippresetdata>();
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
