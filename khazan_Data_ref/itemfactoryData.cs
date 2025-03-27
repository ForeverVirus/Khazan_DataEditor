using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemfactorydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int[] GradeRatio { get; set; }
public PropertyData GradeRatio_Property { get; set; }
    public int[] ItemID { get; set; }
public PropertyData ItemID_Property { get; set; }
}

public class itemfactorydatatbl : KhazanTableBase
{
    public List<itemfactorydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemfactorydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemfactorydata>();
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
