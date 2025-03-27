using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class strengthenitemweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int LevelGap { get; set; }
public PropertyData LevelGap_Property { get; set; }
    public EItemGrade OriginGrade { get; set; }
public PropertyData OriginGrade_Property { get; set; }
    public EItemGrade MaterialGrade { get; set; }
public PropertyData MaterialGrade_Property { get; set; }
    public int PriceRatio { get; set; }
public PropertyData PriceRatio_Property { get; set; }
    public int StrengthenLevel { get; set; }
public PropertyData StrengthenLevel_Property { get; set; }
}

public class strengthenitemweightdatatbl : KhazanTableBase
{
    public List<strengthenitemweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<strengthenitemweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<strengthenitemweightdata>();
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
