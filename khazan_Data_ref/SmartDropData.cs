using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class smartdropdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public int SelectCount { get; set; }
public PropertyData SelectCount_Property { get; set; }
    public int ResetCount { get; set; }
public PropertyData ResetCount_Property { get; set; }
}

public class smartdropdatatbl : KhazanTableBase
{
    public List<smartdropdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<smartdropdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<smartdropdata>();
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
