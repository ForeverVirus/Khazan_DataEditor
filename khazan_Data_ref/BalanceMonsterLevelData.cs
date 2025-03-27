using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancemonsterleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long MissionTidx { get; set; }
public PropertyData MissionTidx_Property { get; set; }
    public long UniqueIndex { get; set; }
public PropertyData UniqueIndex_Property { get; set; }
    public int[] ContentsLevel_Playround { get; set; }
public PropertyData ContentsLevel_Playround_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class balancemonsterleveldatatbl : KhazanTableBase
{
    public List<balancemonsterleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancemonsterleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancemonsterleveldata>();
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
