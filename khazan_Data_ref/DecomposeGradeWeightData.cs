using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class decomposegradeweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public int ExpWeight { get; set; }
public PropertyData ExpWeight_Property { get; set; }
    public int[] MaterialCountWeight { get; set; }
public PropertyData MaterialCountWeight_Property { get; set; }
}

public class decomposegradeweightdatatbl : KhazanTableBase
{
    public List<decomposegradeweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<decomposegradeweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<decomposegradeweightdata>();
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
