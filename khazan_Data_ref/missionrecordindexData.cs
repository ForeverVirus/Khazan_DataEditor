using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missionrecordindexdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int MissionGroupTIDX { get; set; }
public PropertyData MissionGroupTIDX_Property { get; set; }
    public int RecordGroupID { get; set; }
public PropertyData RecordGroupID_Property { get; set; }
    public int ObjectiveMissionTIDX { get; set; }
public PropertyData ObjectiveMissionTIDX_Property { get; set; }
    public int RevengePoint { get; set; }
public PropertyData RevengePoint_Property { get; set; }
    public string ButtonImagePath { get; set; }
public PropertyData ButtonImagePath_Property { get; set; }
}

public class missionrecordindexdatatbl : KhazanTableBase
{
    public List<missionrecordindexdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missionrecordindexdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missionrecordindexdata>();
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
