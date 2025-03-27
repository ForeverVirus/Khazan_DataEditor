using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemrefillgroupdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string ItemRefillDesc { get; set; }
public PropertyData ItemRefillDesc_Property { get; set; }
}

public class itemrefillgroupdatatbl : KhazanTableBase
{
    public List<itemrefillgroupdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemrefillgroupdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemrefillgroupdata>();
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
