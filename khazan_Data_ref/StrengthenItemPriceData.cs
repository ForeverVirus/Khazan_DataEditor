using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class strengthenitempricedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int OrginLevel { get; set; }
public PropertyData OrginLevel_Property { get; set; }
    public int BasePrice { get; set; }
public PropertyData BasePrice_Property { get; set; }
}

public class strengthenitempricedatatbl : KhazanTableBase
{
    public List<strengthenitempricedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<strengthenitempricedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<strengthenitempricedata>();
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
