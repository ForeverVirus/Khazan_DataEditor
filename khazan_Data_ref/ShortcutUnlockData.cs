using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shortcutunlockdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public bool FirstOpen { get; set; }
public PropertyData FirstOpen_Property { get; set; }
    public long Material { get; set; }
public PropertyData Material_Property { get; set; }
    public long Count { get; set; }
public PropertyData Count_Property { get; set; }
}

public class shortcutunlockdatatbl : KhazanTableBase
{
    public List<shortcutunlockdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shortcutunlockdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shortcutunlockdata>();
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
