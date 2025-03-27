using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Blueprint { get; set; }
public PropertyData Blueprint_Property { get; set; }
    public int BasicLevel { get; set; }
public PropertyData BasicLevel_Property { get; set; }
    public int AbilityGroupIndex { get; set; }
public PropertyData AbilityGroupIndex_Property { get; set; }
    public string SkillListInfo { get; set; }
public PropertyData SkillListInfo_Property { get; set; }
}

public class playerdatatbl : KhazanTableBase
{
    public List<playerdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerdata>();
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
