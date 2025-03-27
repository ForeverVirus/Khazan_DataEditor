using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftingmissioncapdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public int[] PlayRoundItemLevel { get; set; }
public PropertyData PlayRoundItemLevel_Property { get; set; }
}

public class craftingmissioncapdatatbl : KhazanTableBase
{
    public List<craftingmissioncapdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftingmissioncapdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftingmissioncapdata>();
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
