using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class loadingtipstringdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ELoadingTooltipCategory TooltipCategory { get; set; }
public PropertyData TooltipCategory_Property { get; set; }
    public string TooltipString { get; set; }
public PropertyData TooltipString_Property { get; set; }
}

public class loadingtipstringdatatbl : KhazanTableBase
{
    public List<loadingtipstringdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<loadingtipstringdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<loadingtipstringdata>();
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
