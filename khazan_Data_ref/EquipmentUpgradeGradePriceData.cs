using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipmentupgradegradepricedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemGrade TargetGrade { get; set; }
public PropertyData TargetGrade_Property { get; set; }
    public EItemGrade MaterialGrade { get; set; }
public PropertyData MaterialGrade_Property { get; set; }
    public int PriceRate { get; set; }
public PropertyData PriceRate_Property { get; set; }
}

public class equipmentupgradegradepricedatatbl : KhazanTableBase
{
    public List<equipmentupgradegradepricedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipmentupgradegradepricedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipmentupgradegradepricedata>();
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
