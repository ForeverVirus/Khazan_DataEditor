using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class noticedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ENoticesType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public ETermsSubType TermsSubType { get; set; }
public PropertyData TermsSubType_Property { get; set; }
    public string TitleText { get; set; }
public PropertyData TitleText_Property { get; set; }
    public string DescriptionText { get; set; }
public PropertyData DescriptionText_Property { get; set; }
    public string ActivateStartDateTimeString { get; set; }
public PropertyData ActivateStartDateTimeString_Property { get; set; }
    public int ActivateDay { get; set; }
public PropertyData ActivateDay_Property { get; set; }
    public int DisplayCount { get; set; }
public PropertyData DisplayCount_Property { get; set; }
    public bool bEnable { get; set; }
public PropertyData bEnable_Property { get; set; }
}

public class noticedatatbl : KhazanTableBase
{
    public List<noticedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<noticedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<noticedata>();
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
