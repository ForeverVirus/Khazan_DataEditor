using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopbuymissioncapdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public int PlayRoundItemLevel1 { get; set; }
public PropertyData PlayRoundItemLevel1_Property { get; set; }
    public int PlayRoundItemLevel2 { get; set; }
public PropertyData PlayRoundItemLevel2_Property { get; set; }
    public int PlayRoundItemLevel3 { get; set; }
public PropertyData PlayRoundItemLevel3_Property { get; set; }
    public int PlayRoundItemLevel4 { get; set; }
public PropertyData PlayRoundItemLevel4_Property { get; set; }
    public int PlayRoundItemLevel5 { get; set; }
public PropertyData PlayRoundItemLevel5_Property { get; set; }
}

public class shopbuymissioncapdatatbl : KhazanTableBase
{
    public List<shopbuymissioncapdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopbuymissioncapdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopbuymissioncapdata>();
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
