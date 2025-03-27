using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class npcmenusetdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int Ability1 { get; set; }
public PropertyData Ability1_Property { get; set; }
    public string AbilityText1 { get; set; }
public PropertyData AbilityText1_Property { get; set; }
    public int Ability2 { get; set; }
public PropertyData Ability2_Property { get; set; }
    public string AbilityText2 { get; set; }
public PropertyData AbilityText2_Property { get; set; }
    public int Ability3 { get; set; }
public PropertyData Ability3_Property { get; set; }
    public string AbilityText3 { get; set; }
public PropertyData AbilityText3_Property { get; set; }
    public int Ability4 { get; set; }
public PropertyData Ability4_Property { get; set; }
    public string AbilityText4 { get; set; }
public PropertyData AbilityText4_Property { get; set; }
    public int Ability5 { get; set; }
public PropertyData Ability5_Property { get; set; }
    public string AbilityText5 { get; set; }
public PropertyData AbilityText5_Property { get; set; }
}

public class npcmenusetdatatbl : KhazanTableBase
{
    public List<npcmenusetdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<npcmenusetdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<npcmenusetdata>();
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
