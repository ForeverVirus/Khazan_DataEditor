using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipmentdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public Base Base { get; set; }
public PropertyData Base_Property { get; set; }
    public EItemTier Tier { get; set; }
public PropertyData Tier_Property { get; set; }
    public int ProportionOption1TIDX { get; set; }
public PropertyData ProportionOption1TIDX_Property { get; set; }
    public int ProportionOption2TIDX { get; set; }
public PropertyData ProportionOption2TIDX_Property { get; set; }
    public int EquipLevelGroupTIDX { get; set; }
public PropertyData EquipLevelGroupTIDX_Property { get; set; }
    public EGrBaseStatus Stat1ID { get; set; }
public PropertyData Stat1ID_Property { get; set; }
    public int Stat1Value { get; set; }
public PropertyData Stat1Value_Property { get; set; }
    public EGrBaseStatus Stat2ID { get; set; }
public PropertyData Stat2ID_Property { get; set; }
    public int Stat2Value { get; set; }
public PropertyData Stat2Value_Property { get; set; }
    public EGrBaseStatus UnlockStat1ID { get; set; }
public PropertyData UnlockStat1ID_Property { get; set; }
    public int UnlockStat1Value { get; set; }
public PropertyData UnlockStat1Value_Property { get; set; }
    public EGrBaseStatus UnlockStat2ID { get; set; }
public PropertyData UnlockStat2ID_Property { get; set; }
    public int UnlockStat2Value { get; set; }
public PropertyData UnlockStat2Value_Property { get; set; }
    public string InherentStat1Name { get; set; }
public PropertyData InherentStat1Name_Property { get; set; }
    public int InherentOption1TIDX { get; set; }
public PropertyData InherentOption1TIDX_Property { get; set; }
    public string InherentStat2Name { get; set; }
public PropertyData InherentStat2Name_Property { get; set; }
    public int InherentOption2TIDX { get; set; }
public PropertyData InherentOption2TIDX_Property { get; set; }
    public string InherentStat3Name { get; set; }
public PropertyData InherentStat3Name_Property { get; set; }
    public int InherentOption3TIDX { get; set; }
public PropertyData InherentOption3TIDX_Property { get; set; }
    public EItemGrade InherentOption1Grade { get; set; }
public PropertyData InherentOption1Grade_Property { get; set; }
    public EItemGrade InherentOption2Grade { get; set; }
public PropertyData InherentOption2Grade_Property { get; set; }
    public EItemGrade InherentOption3Grade { get; set; }
public PropertyData InherentOption3Grade_Property { get; set; }
    public int FireDefence { get; set; }
public PropertyData FireDefence_Property { get; set; }
    public int WaterDefence { get; set; }
public PropertyData WaterDefence_Property { get; set; }
    public int ElectricDefence { get; set; }
public PropertyData ElectricDefence_Property { get; set; }
    public int EarthDefence { get; set; }
public PropertyData EarthDefence_Property { get; set; }
    public int PoisonDefence { get; set; }
public PropertyData PoisonDefence_Property { get; set; }
    public int DiseaseDefence { get; set; }
public PropertyData DiseaseDefence_Property { get; set; }
    public int ChaosDefence { get; set; }
public PropertyData ChaosDefence_Property { get; set; }
    public int SetItemTIDX { get; set; }
public PropertyData SetItemTIDX_Property { get; set; }
    public string Look_Mesh { get; set; }
public PropertyData Look_Mesh_Property { get; set; }
    public string Look_Animation { get; set; }
public PropertyData Look_Animation_Property { get; set; }
    public float EquipWeight { get; set; }
public PropertyData EquipWeight_Property { get; set; }
    public EItemGrade FixedGrade { get; set; }
public PropertyData FixedGrade_Property { get; set; }
}

public class equipmentdatatbl : KhazanTableBase
{
    public List<equipmentdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipmentdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipmentdata>();
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
