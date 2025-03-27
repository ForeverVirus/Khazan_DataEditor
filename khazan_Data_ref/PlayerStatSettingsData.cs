using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class playerstatsettingsdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int Order { get; set; }
public PropertyData Order_Property { get; set; }
    public EGrBaseStatus Stat { get; set; }
public PropertyData Stat_Property { get; set; }
    public EItemOptionValue DisplayValueType { get; set; }
public PropertyData DisplayValueType_Property { get; set; }
}

public class playerstatsettingsdatatbl : KhazanTableBase
{
    public List<playerstatsettingsdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<playerstatsettingsdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<playerstatsettingsdata>();
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
