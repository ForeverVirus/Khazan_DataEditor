using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipmentupgradepricedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int[] Grade { get; set; }
public PropertyData Grade_Property { get; set; }
}

public class equipmentupgradepricedatatbl : KhazanTableBase
{
    public List<equipmentupgradepricedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipmentupgradepricedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipmentupgradepricedata>();
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
