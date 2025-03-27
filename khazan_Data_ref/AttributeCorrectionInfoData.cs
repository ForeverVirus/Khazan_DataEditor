using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class attributecorrectioninfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EKazanWeaponType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public int FireCorrectionRate { get; set; }
public PropertyData FireCorrectionRate_Property { get; set; }
    public int WaterCorrectionRate { get; set; }
public PropertyData WaterCorrectionRate_Property { get; set; }
    public int ElectricCorrectionRate { get; set; }
public PropertyData ElectricCorrectionRate_Property { get; set; }
    public int EarthCorrectionRate { get; set; }
public PropertyData EarthCorrectionRate_Property { get; set; }
    public int PoisonCorrectionRate { get; set; }
public PropertyData PoisonCorrectionRate_Property { get; set; }
    public int DeseaseCorrectionRate { get; set; }
public PropertyData DeseaseCorrectionRate_Property { get; set; }
    public int ChaosCorrectionRate { get; set; }
public PropertyData ChaosCorrectionRate_Property { get; set; }
    public int FireCorrectionAccrueRate { get; set; }
public PropertyData FireCorrectionAccrueRate_Property { get; set; }
    public int WaterCorrectionAccrueRate { get; set; }
public PropertyData WaterCorrectionAccrueRate_Property { get; set; }
    public int ElectricCorrectionAccrueRate { get; set; }
public PropertyData ElectricCorrectionAccrueRate_Property { get; set; }
    public int EarthCorrectionAccrueRate { get; set; }
public PropertyData EarthCorrectionAccrueRate_Property { get; set; }
    public int PoisonCorrectionAccrueRate { get; set; }
public PropertyData PoisonCorrectionAccrueRate_Property { get; set; }
    public int DeseaseCorrectionAccrueRate { get; set; }
public PropertyData DeseaseCorrectionAccrueRate_Property { get; set; }
    public int ChaosCorrectionAccrueRate { get; set; }
public PropertyData ChaosCorrectionAccrueRate_Property { get; set; }
}

public class attributecorrectioninfodatatbl : KhazanTableBase
{
    public List<attributecorrectioninfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<attributecorrectioninfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<attributecorrectioninfodata>();
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
