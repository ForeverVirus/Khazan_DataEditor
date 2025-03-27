using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class masterymissionleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public int WeaponMaxLevel_Round01 { get; set; }
public PropertyData WeaponMaxLevel_Round01_Property { get; set; }
    public int CommonMaxLevel_Round01 { get; set; }
public PropertyData CommonMaxLevel_Round01_Property { get; set; }
    public int WeaponMaxLevel_Round02 { get; set; }
public PropertyData WeaponMaxLevel_Round02_Property { get; set; }
    public int CommonMaxLevel_Round02 { get; set; }
public PropertyData CommonMaxLevel_Round02_Property { get; set; }
    public int WeaponMaxLevel_Round03 { get; set; }
public PropertyData WeaponMaxLevel_Round03_Property { get; set; }
    public int CommonMaxLevel_Round03 { get; set; }
public PropertyData CommonMaxLevel_Round03_Property { get; set; }
    public int WeaponMaxLevel_Round04 { get; set; }
public PropertyData WeaponMaxLevel_Round04_Property { get; set; }
    public int CommonMaxLevel_Round04 { get; set; }
public PropertyData CommonMaxLevel_Round04_Property { get; set; }
    public int WeaponMaxLevel_Round05 { get; set; }
public PropertyData WeaponMaxLevel_Round05_Property { get; set; }
    public int CommonMaxLevel_Round05 { get; set; }
public PropertyData CommonMaxLevel_Round05_Property { get; set; }
}

public class masterymissionleveldatatbl : KhazanTableBase
{
    public List<masterymissionleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<masterymissionleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<masterymissionleveldata>();
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
