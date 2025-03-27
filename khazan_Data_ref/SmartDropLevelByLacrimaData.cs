using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class smartdroplevelbylacrimadata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int SmartDropStandardLevel { get; set; }
public PropertyData SmartDropStandardLevel_Property { get; set; }
    public long CumulativeExp { get; set; }
public PropertyData CumulativeExp_Property { get; set; }
}

public class smartdroplevelbylacrimadatatbl : KhazanTableBase
{
    public List<smartdroplevelbylacrimadata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<smartdroplevelbylacrimadata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<smartdroplevelbylacrimadata>();
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
