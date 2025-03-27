using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemoptionvaluedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public int BlackListGroup { get; set; }
public PropertyData BlackListGroup_Property { get; set; }
    public int Ratio { get; set; }
public PropertyData Ratio_Property { get; set; }
    public EGrBaseStatus StatID { get; set; }
public PropertyData StatID_Property { get; set; }
    public int MinValue { get; set; }
public PropertyData MinValue_Property { get; set; }
    public int MaxValue { get; set; }
public PropertyData MaxValue_Property { get; set; }
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
    public bool CanGrinding { get; set; }
public PropertyData CanGrinding_Property { get; set; }
    public bool CanReplace { get; set; }
public PropertyData CanReplace_Property { get; set; }
    public bool CanSuccession { get; set; }
public PropertyData CanSuccession_Property { get; set; }
    public EOptionContentOrigin OptionOrigin { get; set; }
public PropertyData OptionOrigin_Property { get; set; }
}

public class itemoptionvaluedatatbl : KhazanTableBase
{
    public List<itemoptionvaluedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemoptionvaluedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemoptionvaluedata>();
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
