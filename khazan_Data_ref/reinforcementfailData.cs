using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class reinforcementfaildata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public EReinforceFailType ReinforceFailType { get; set; }
public PropertyData ReinforceFailType_Property { get; set; }
    public int ReduceLevel { get; set; }
public PropertyData ReduceLevel_Property { get; set; }
    public int Weight { get; set; }
public PropertyData Weight_Property { get; set; }
    public EReduceStatusType ReduceStatusType { get; set; }
public PropertyData ReduceStatusType_Property { get; set; }
}

public class reinforcementfaildatatbl : KhazanTableBase
{
    public List<reinforcementfaildata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<reinforcementfaildata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<reinforcementfaildata>();
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
