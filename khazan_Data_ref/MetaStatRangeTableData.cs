using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class metastatrangetabledata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string StatName { get; set; }
public PropertyData StatName_Property { get; set; }
    public EMetaStatRange Stat { get; set; }
public PropertyData Stat_Property { get; set; }
    public int RangeMin { get; set; }
public PropertyData RangeMin_Property { get; set; }
    public int RangeMax { get; set; }
public PropertyData RangeMax_Property { get; set; }
}

public class metastatrangetabledatatbl : KhazanTableBase
{
    public List<metastatrangetabledata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<metastatrangetabledata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<metastatrangetabledata>();
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
