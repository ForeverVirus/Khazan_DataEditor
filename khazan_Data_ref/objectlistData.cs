using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class objectlistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Blueprint { get; set; }
public PropertyData Blueprint_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int BasicLevel { get; set; }
public PropertyData BasicLevel_Property { get; set; }
    public int BaseInfoGroupIndex { get; set; }
public PropertyData BaseInfoGroupIndex_Property { get; set; }
    public EObjectType ObjectType { get; set; }
public PropertyData ObjectType_Property { get; set; }
    public EOverheadGaugeType OverHeadGaugeType { get; set; }
public PropertyData OverHeadGaugeType_Property { get; set; }
    public int FactionTIDX { get; set; }
public PropertyData FactionTIDX_Property { get; set; }
    public EMinimapIconType MinimapIconType { get; set; }
public PropertyData MinimapIconType_Property { get; set; }
}

public class objectlistdatatbl : KhazanTableBase
{
    public List<objectlistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<objectlistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<objectlistdata>();
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
