using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class metastatweighttabledata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string StatName { get; set; }
public PropertyData StatName_Property { get; set; }
    public EGrBaseStatus Stat { get; set; }
public PropertyData Stat_Property { get; set; }
    public EStatClass StatClass { get; set; }
public PropertyData StatClass_Property { get; set; }
    public float StatWeight { get; set; }
public PropertyData StatWeight_Property { get; set; }
}

public class metastatweighttabledatatbl : KhazanTableBase
{
    public List<metastatweighttabledata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<metastatweighttabledata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<metastatweighttabledata>();
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
