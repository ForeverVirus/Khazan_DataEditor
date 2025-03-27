using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class systemmessagedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EGameMessageType WidgetType { get; set; }
public PropertyData WidgetType_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public string ContentType { get; set; }
public PropertyData ContentType_Property { get; set; }
    public string Format { get; set; }
public PropertyData Format_Property { get; set; }
    public string IconPath { get; set; }
public PropertyData IconPath_Property { get; set; }
}

public class systemmessagedatatbl : KhazanTableBase
{
    public List<systemmessagedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<systemmessagedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<systemmessagedata>();
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
