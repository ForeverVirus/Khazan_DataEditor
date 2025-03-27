using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class RewardMaterial : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Type { get; set; }
public PropertyData Type_Property { get; set; }
    public int Count { get; set; }
public PropertyData Count_Property { get; set; }
    public int Probability { get; set; }
public PropertyData Probability_Property { get; set; }
}

public class decomposebonusdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int RewardMaterialCount { get; set; }
public PropertyData RewardMaterialCount_Property { get; set; }
    public RewardMaterial[] RewardMaterial { get; set; }
public PropertyData RewardMaterial_Property { get; set; }
}

public class decomposebonusdatatbl : KhazanTableBase
{
    public List<decomposebonusdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<decomposebonusdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<decomposebonusdata>();
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
