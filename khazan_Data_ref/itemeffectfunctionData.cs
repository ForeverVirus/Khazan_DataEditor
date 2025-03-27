using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class itemeffectfunctionData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EItemEffectType ItemEffectType { get; set; }
    public EStatPoint StatPoint { get; set; }
    public EMissionStop MissionStop { get; set; }
    public EMasteryItem Mastery { get; set; }
    public EItemType Item { get; set; }
    public int ItemRefillGroup { get; set; }
    public EStatusEffectAttribute StatusEffectAttribute { get; set; }
    public int Skill { get; set; }
    public int StatusEffect { get; set; }
    public long DurationTime { get; set; }
    public EGrDynamicStatus StatusRecovery { get; set; }
    public int EffectDuration { get; set; }
    public int Value { get; set; }
    public EItemEffectValueType ValueType { get; set; }
    public string ParticlePath { get; set; }
    public EItemEffectAction State { get; set; }
    public string CoiPath { get; set; }
    public string Desc { get; set; }
}

public class itemeffectfunctionDataTbl : KhazanTableBase
{
    public List<itemeffectfunctionData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<itemeffectfunctionData>();
        var dataArray = array.ToObject<itemeffectfunctionData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
