using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class damagefloaterprioritydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EDamageFloaterEffectType EffectType { get; set; }
public PropertyData EffectType_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public EDamageFloaterAttackType AttackType { get; set; }
public PropertyData AttackType_Property { get; set; }
    public long Priority { get; set; }
public PropertyData Priority_Property { get; set; }
}

public class damagefloaterprioritydatatbl : KhazanTableBase
{
    public List<damagefloaterprioritydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<damagefloaterprioritydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<damagefloaterprioritydata>();
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
