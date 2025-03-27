using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class contentsconstantsdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public double UpgradeLevelPriceDefault { get; set; }
public PropertyData UpgradeLevelPriceDefault_Property { get; set; }
    public double UpgradeLevelPriceCorrection { get; set; }
public PropertyData UpgradeLevelPriceCorrection_Property { get; set; }
    public int MaxWeaponDropCount { get; set; }
public PropertyData MaxWeaponDropCount_Property { get; set; }
    public int MaxArmorDropCount { get; set; }
public PropertyData MaxArmorDropCount_Property { get; set; }
    public int MaxAccDropCount { get; set; }
public PropertyData MaxAccDropCount_Property { get; set; }
}

public class contentsconstantsdatatbl : KhazanTableBase
{
    public List<contentsconstantsdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<contentsconstantsdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<contentsconstantsdata>();
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
