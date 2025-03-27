using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balanceoptioninfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public EGrBaseStatus StatID { get; set; }
public PropertyData StatID_Property { get; set; }
    public int StatValue { get; set; }
public PropertyData StatValue_Property { get; set; }
    public EItemOptionCondition Condition1ID { get; set; }
public PropertyData Condition1ID_Property { get; set; }
    public int Condition1Value { get; set; }
public PropertyData Condition1Value_Property { get; set; }
    public EDyanmicOptionApplyType Condition1ApplyType { get; set; }
public PropertyData Condition1ApplyType_Property { get; set; }
    public EItemOptionCondition Condition2ID { get; set; }
public PropertyData Condition2ID_Property { get; set; }
    public int Condition2Value { get; set; }
public PropertyData Condition2Value_Property { get; set; }
    public EDyanmicOptionApplyType Condition2ApplyType { get; set; }
public PropertyData Condition2ApplyType_Property { get; set; }
    public int StatusEffect { get; set; }
public PropertyData StatusEffect_Property { get; set; }
    public EStatusEffectRemoveType StatusEffectRemoveType { get; set; }
public PropertyData StatusEffectRemoveType_Property { get; set; }
    public int SkillName { get; set; }
public PropertyData SkillName_Property { get; set; }
    public int SkillLevel { get; set; }
public PropertyData SkillLevel_Property { get; set; }
}

public class balanceoptioninfodatatbl : KhazanTableBase
{
    public List<balanceoptioninfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balanceoptioninfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balanceoptioninfodata>();
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
