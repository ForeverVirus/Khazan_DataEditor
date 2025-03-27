using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class cinematicdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string SequenceName { get; set; }
public PropertyData SequenceName_Property { get; set; }
    public string AudioEventName_Begin { get; set; }
public PropertyData AudioEventName_Begin_Property { get; set; }
    public string AudioEventName_End { get; set; }
public PropertyData AudioEventName_End_Property { get; set; }
}

public class cinematicdatatbl : KhazanTableBase
{
    public List<cinematicdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<cinematicdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<cinematicdata>();
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
