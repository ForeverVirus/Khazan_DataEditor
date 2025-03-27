using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerabilitydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public Status Status { get; set; }
public PropertyData Status_Property { get; set; }
}

public class playerabilitydatatbl : KhazanTableBase
{
    public List<playerabilitydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerabilitydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerabilitydata>();
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
