using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class masteryweightdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MasteryLevelGap { get; set; }
public PropertyData MasteryLevelGap_Property { get; set; }
    public int WeightValue { get; set; }
public PropertyData WeightValue_Property { get; set; }
}

public class masteryweightdatatbl : KhazanTableBase
{
    public List<masteryweightdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<masteryweightdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<masteryweightdata>();
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
