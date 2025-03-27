using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancecommandhubdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int MissionTable { get; set; }
public PropertyData MissionTable_Property { get; set; }
    public int PCLevel { get; set; }
public PropertyData PCLevel_Property { get; set; }
    public int EquipmentLvel { get; set; }
public PropertyData EquipmentLvel_Property { get; set; }
    public int Exp { get; set; }
public PropertyData Exp_Property { get; set; }
    public int Body { get; set; }
public PropertyData Body_Property { get; set; }
    public int Heart { get; set; }
public PropertyData Heart_Property { get; set; }
    public int Strength { get; set; }
public PropertyData Strength_Property { get; set; }
    public int Force { get; set; }
public PropertyData Force_Property { get; set; }
    public int Skill { get; set; }
public PropertyData Skill_Property { get; set; }
    public int WeaponMastery { get; set; }
public PropertyData WeaponMastery_Property { get; set; }
    public int CommonMastery { get; set; }
public PropertyData CommonMastery_Property { get; set; }
    public int LAPresetID { get; set; }
public PropertyData LAPresetID_Property { get; set; }
    public int HAPresetID { get; set; }
public PropertyData HAPresetID_Property { get; set; }
    public int PAPresetID { get; set; }
public PropertyData PAPresetID_Property { get; set; }
    public int DAPresetID { get; set; }
public PropertyData DAPresetID_Property { get; set; }
    public int GSPresetID { get; set; }
public PropertyData GSPresetID_Property { get; set; }
    public int SpearPresetID { get; set; }
public PropertyData SpearPresetID_Property { get; set; }
    public string LAPresetName { get; set; }
public PropertyData LAPresetName_Property { get; set; }
    public string HAPresetName { get; set; }
public PropertyData HAPresetName_Property { get; set; }
    public string PAPresetName { get; set; }
public PropertyData PAPresetName_Property { get; set; }
    public string DAPresetName { get; set; }
public PropertyData DAPresetName_Property { get; set; }
    public string GSPresetName { get; set; }
public PropertyData GSPresetName_Property { get; set; }
    public string SpearPresetName { get; set; }
public PropertyData SpearPresetName_Property { get; set; }
}

public class balancecommandhubdatatbl : KhazanTableBase
{
    public List<balancecommandhubdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancecommandhubdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancecommandhubdata>();
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
