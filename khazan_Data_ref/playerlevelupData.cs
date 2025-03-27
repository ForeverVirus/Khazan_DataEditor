using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerlevelupdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public long ReqExp { get; set; }
public PropertyData ReqExp_Property { get; set; }
    public long CumulativeExp { get; set; }
public PropertyData CumulativeExp_Property { get; set; }
}

public class playerlevelupdatatbl : KhazanTableBase
{
    public List<playerlevelupdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerlevelupdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerlevelupdata>();
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
