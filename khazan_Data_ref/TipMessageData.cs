using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class tipmessagedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Title { get; set; }
public PropertyData Title_Property { get; set; }
    public string TipDesc { get; set; }
public PropertyData TipDesc_Property { get; set; }
    public int UnLockMissionTIDX { get; set; }
public PropertyData UnLockMissionTIDX_Property { get; set; }
    public ETipMessageType TipMessageType { get; set; }
public PropertyData TipMessageType_Property { get; set; }
}

public class tipmessagedatatbl : KhazanTableBase
{
    public List<tipmessagedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<tipmessagedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<tipmessagedata>();
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
