using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class weaponskilloptioninfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public EWeaponSkillStat StatID { get; set; }
public PropertyData StatID_Property { get; set; }
    public int StatCondition { get; set; }
public PropertyData StatCondition_Property { get; set; }
    public int StatValue { get; set; }
public PropertyData StatValue_Property { get; set; }
    public EWeaponSkillCondition Condition1ID { get; set; }
public PropertyData Condition1ID_Property { get; set; }
    public int Condition1Value { get; set; }
public PropertyData Condition1Value_Property { get; set; }
    public string Condition1StrValue { get; set; }
public PropertyData Condition1StrValue_Property { get; set; }
    public EWeaponSkillCondition Condition2ID { get; set; }
public PropertyData Condition2ID_Property { get; set; }
    public int Condition2Value { get; set; }
public PropertyData Condition2Value_Property { get; set; }
    public string Condition2StrValue { get; set; }
public PropertyData Condition2StrValue_Property { get; set; }
}

public class weaponskilloptioninfodatatbl : KhazanTableBase
{
    public List<weaponskilloptioninfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<weaponskilloptioninfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<weaponskilloptioninfodata>();
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
