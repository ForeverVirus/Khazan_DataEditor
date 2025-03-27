using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class decomposebonusrangedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int NextTIDX { get; set; }
public PropertyData NextTIDX_Property { get; set; }
    public int MaxExp { get; set; }
public PropertyData MaxExp_Property { get; set; }
    public int BonusTIDX { get; set; }
public PropertyData BonusTIDX_Property { get; set; }
}

public class decomposebonusrangedatatbl : KhazanTableBase
{
    public List<decomposebonusrangedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<decomposebonusrangedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<decomposebonusrangedata>();
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
