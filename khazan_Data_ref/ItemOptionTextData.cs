using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemoptiontextdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public EGrBaseStatus StatID { get; set; }
public PropertyData StatID_Property { get; set; }
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
    public int MinValue { get; set; }
public PropertyData MinValue_Property { get; set; }
    public int MaxValue { get; set; }
public PropertyData MaxValue_Property { get; set; }
    public int StatusEffect { get; set; }
public PropertyData StatusEffect_Property { get; set; }
    public int SkillName { get; set; }
public PropertyData SkillName_Property { get; set; }
    public int SkillLevel { get; set; }
public PropertyData SkillLevel_Property { get; set; }
    public string ValueText { get; set; }
public PropertyData ValueText_Property { get; set; }
    public string ConditionTag { get; set; }
public PropertyData ConditionTag_Property { get; set; }
    public bool bDisplayEncyclopedia { get; set; }
public PropertyData bDisplayEncyclopedia_Property { get; set; }
    public int DisplayEncyclopediaNeedMissionTIDX { get; set; }
public PropertyData DisplayEncyclopediaNeedMissionTIDX_Property { get; set; }
    public int[] ItemAddInfoTIDX { get; set; }
public PropertyData ItemAddInfoTIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class itemoptiontextdatatbl : KhazanTableBase
{
    public List<itemoptiontextdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemoptiontextdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemoptiontextdata>();
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
