using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missionclearresetitemdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public EItemType ItemType { get; set; }
public PropertyData ItemType_Property { get; set; }
    public int ItemTIDX { get; set; }
public PropertyData ItemTIDX_Property { get; set; }
}

public class missionclearresetitemdatatbl : KhazanTableBase
{
    public List<missionclearresetitemdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missionclearresetitemdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missionclearresetitemdata>();
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
