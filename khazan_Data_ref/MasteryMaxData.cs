using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class masterymaxdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public int MasteryValue { get; set; }
public PropertyData MasteryValue_Property { get; set; }
}

public class masterymaxdatatbl : KhazanTableBase
{
    public List<masterymaxdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<masterymaxdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<masterymaxdata>();
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
