using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class baseobjectinfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public EObjectType ObjectType { get; set; }
public PropertyData ObjectType_Property { get; set; }
    public EObjectCollectType ObjectCollectType { get; set; }
public PropertyData ObjectCollectType_Property { get; set; }
    public EObjectRarity ObjectRarity { get; set; }
public PropertyData ObjectRarity_Property { get; set; }
    public int ConsPowerBonus { get; set; }
public PropertyData ConsPowerBonus_Property { get; set; }
    public int ConsHealthPoint { get; set; }
public PropertyData ConsHealthPoint_Property { get; set; }
    public Status Status { get; set; }
public PropertyData Status_Property { get; set; }
}

public class baseobjectinfodatatbl : KhazanTableBase
{
    public List<baseobjectinfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<baseobjectinfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<baseobjectinfodata>();
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
