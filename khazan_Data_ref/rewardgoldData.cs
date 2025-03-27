using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class rewardgolddata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ERewardGold ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int ContentsLevel { get; set; }
public PropertyData ContentsLevel_Property { get; set; }
    public int Min { get; set; }
public PropertyData Min_Property { get; set; }
    public int Max { get; set; }
public PropertyData Max_Property { get; set; }
}

public class rewardgolddatatbl : KhazanTableBase
{
    public List<rewardgolddata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<rewardgolddata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<rewardgolddata>();
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
