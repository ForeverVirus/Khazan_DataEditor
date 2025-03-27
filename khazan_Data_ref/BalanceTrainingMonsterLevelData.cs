using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class balancetrainingmonsterleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long ClearedMissionTIDX { get; set; }
public PropertyData ClearedMissionTIDX_Property { get; set; }
    public int[] CombatLevel_Playground { get; set; }
public PropertyData CombatLevel_Playground_Property { get; set; }
}

public class balancetrainingmonsterleveldatatbl : KhazanTableBase
{
    public List<balancetrainingmonsterleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balancetrainingmonsterleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balancetrainingmonsterleveldata>();
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
