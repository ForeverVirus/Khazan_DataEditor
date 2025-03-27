using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class factiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public ERelationShipType Player_Default { get; set; }
public PropertyData Player_Default_Property { get; set; }
    public ERelationShipType Monster_Default { get; set; }
public PropertyData Monster_Default_Property { get; set; }
    public ERelationShipType LOB_Default { get; set; }
public PropertyData LOB_Default_Property { get; set; }
    public ERelationShipType LOB_All_Attack { get; set; }
public PropertyData LOB_All_Attack_Property { get; set; }
    public ERelationShipType Monster_Red { get; set; }
public PropertyData Monster_Red_Property { get; set; }
    public ERelationShipType Monster_Blue { get; set; }
public PropertyData Monster_Blue_Property { get; set; }
    public ERelationShipType Monster_Neutral { get; set; }
public PropertyData Monster_Neutral_Property { get; set; }
    public bool IsPVPTarget { get; set; }
public PropertyData IsPVPTarget_Property { get; set; }
}

public class factiondatatbl : KhazanTableBase
{
    public List<factiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<factiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<factiondata>();
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
