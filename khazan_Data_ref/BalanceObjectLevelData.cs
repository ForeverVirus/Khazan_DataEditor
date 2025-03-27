using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class StaticLobIteminfo : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int ContentsLevel_Playround { get; set; }
public PropertyData ContentsLevel_Playround_Property { get; set; }
    public EItemGrade ItemGrade_Playround { get; set; }
public PropertyData ItemGrade_Playround_Property { get; set; }
}

public class balanceobjectleveldata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MissionTidx { get; set; }
public PropertyData MissionTidx_Property { get; set; }
    public int UniqueIndex { get; set; }
public PropertyData UniqueIndex_Property { get; set; }
    public StaticLobIteminfo[] StaticLobIteminfo { get; set; }
public PropertyData StaticLobIteminfo_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
}

public class balanceobjectleveldatatbl : KhazanTableBase
{
    public List<balanceobjectleveldata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<balanceobjectleveldata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<balanceobjectleveldata>();
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
