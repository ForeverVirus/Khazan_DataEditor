using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class metastatcalculationdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public EOptionOrigin OptionOrigin { get; set; }
public PropertyData OptionOrigin_Property { get; set; }
    public EOptionScoreType ScoreType { get; set; }
public PropertyData ScoreType_Property { get; set; }
    public EGrBaseStatus StatID { get; set; }
public PropertyData StatID_Property { get; set; }
    public int StatusEffect { get; set; }
public PropertyData StatusEffect_Property { get; set; }
    public int Skill { get; set; }
public PropertyData Skill_Property { get; set; }
    public EItemOptionCondition Condition1ID { get; set; }
public PropertyData Condition1ID_Property { get; set; }
    public int Condition1Value { get; set; }
public PropertyData Condition1Value_Property { get; set; }
    public EItemOptionCondition Condition2ID { get; set; }
public PropertyData Condition2ID_Property { get; set; }
    public int Condition2Value { get; set; }
public PropertyData Condition2Value_Property { get; set; }
    public int MinValue { get; set; }
public PropertyData MinValue_Property { get; set; }
    public int MaxValue { get; set; }
public PropertyData MaxValue_Property { get; set; }
    public float FixValue { get; set; }
public PropertyData FixValue_Property { get; set; }
}

public class metastatcalculationdatatbl : KhazanTableBase
{
    public List<metastatcalculationdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<metastatcalculationdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<metastatcalculationdata>();
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
