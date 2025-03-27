using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemaddinfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public bool Weapon { get; set; }
public PropertyData Weapon_Property { get; set; }
    public bool Armor { get; set; }
public PropertyData Armor_Property { get; set; }
    public bool Accessory { get; set; }
public PropertyData Accessory_Property { get; set; }
    public bool bDisplayEncyclopedia { get; set; }
public PropertyData bDisplayEncyclopedia_Property { get; set; }
    public int DisplayEncyclopediaNeedMissionTIDX { get; set; }
public PropertyData DisplayEncyclopediaNeedMissionTIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class itemaddinfodatatbl : KhazanTableBase
{
    public List<itemaddinfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemaddinfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemaddinfodata>();
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
