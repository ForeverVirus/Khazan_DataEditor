using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemeffectfunctiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemEffectType ItemEffectType { get; set; }
public PropertyData ItemEffectType_Property { get; set; }
    public EStatPoint StatPoint { get; set; }
public PropertyData StatPoint_Property { get; set; }
    public EMissionStop MissionStop { get; set; }
public PropertyData MissionStop_Property { get; set; }
    public EMasteryItem Mastery { get; set; }
public PropertyData Mastery_Property { get; set; }
    public EItemType Item { get; set; }
public PropertyData Item_Property { get; set; }
    public int ItemRefillGroup { get; set; }
public PropertyData ItemRefillGroup_Property { get; set; }
    public EStatusEffectAttribute StatusEffectAttribute { get; set; }
public PropertyData StatusEffectAttribute_Property { get; set; }
    public int Skill { get; set; }
public PropertyData Skill_Property { get; set; }
    public int StatusEffect { get; set; }
public PropertyData StatusEffect_Property { get; set; }
    public long DurationTime { get; set; }
public PropertyData DurationTime_Property { get; set; }
    public EGrDynamicStatus StatusRecovery { get; set; }
public PropertyData StatusRecovery_Property { get; set; }
    public int EffectDuration { get; set; }
public PropertyData EffectDuration_Property { get; set; }
    public int Value { get; set; }
public PropertyData Value_Property { get; set; }
    public EItemEffectValueType ValueType { get; set; }
public PropertyData ValueType_Property { get; set; }
    public string ParticlePath { get; set; }
public PropertyData ParticlePath_Property { get; set; }
    public EItemEffectAction State { get; set; }
public PropertyData State_Property { get; set; }
    public string CoiPath { get; set; }
public PropertyData CoiPath_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
}

public class itemeffectfunctiondatatbl : KhazanTableBase
{
    public List<itemeffectfunctiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemeffectfunctiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemeffectfunctiondata>();
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
