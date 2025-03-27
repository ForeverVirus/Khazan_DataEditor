using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemoptionlinkdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public string ExcludeListName { get; set; }
public PropertyData ExcludeListName_Property { get; set; }
    public int ItemOptionGroupTIDX { get; set; }
public PropertyData ItemOptionGroupTIDX_Property { get; set; }
    public int ItemOptionValueTIDX { get; set; }
public PropertyData ItemOptionValueTIDX_Property { get; set; }
}

public class itemoptionlinkdatatbl : KhazanTableBase
{
    public List<itemoptionlinkdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemoptionlinkdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemoptionlinkdata>();
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
