using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class sequencedialoguedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Speaker { get; set; }
public PropertyData Speaker_Property { get; set; }
    public string SpeakerStyleName { get; set; }
public PropertyData SpeakerStyleName_Property { get; set; }
    public string Dialogue { get; set; }
public PropertyData Dialogue_Property { get; set; }
    public long ConnectSpawnIDX { get; set; }
public PropertyData ConnectSpawnIDX_Property { get; set; }
    public string OVRLipsyncAssetPath { get; set; }
public PropertyData OVRLipsyncAssetPath_Property { get; set; }
}

public class sequencedialoguedatatbl : KhazanTableBase
{
    public List<sequencedialoguedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<sequencedialoguedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<sequencedialoguedata>();
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
