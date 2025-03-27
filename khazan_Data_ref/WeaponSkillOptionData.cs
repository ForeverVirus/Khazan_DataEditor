using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class weaponskilloptiondata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupID { get; set; }
public PropertyData GroupID_Property { get; set; }
    public int SkillLevel { get; set; }
public PropertyData SkillLevel_Property { get; set; }
    public string StatName { get; set; }
public PropertyData StatName_Property { get; set; }
    public int OptionTIDX { get; set; }
public PropertyData OptionTIDX_Property { get; set; }
}

public class weaponskilloptiondatatbl : KhazanTableBase
{
    public List<weaponskilloptiondata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<weaponskilloptiondata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<weaponskilloptiondata>();
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
