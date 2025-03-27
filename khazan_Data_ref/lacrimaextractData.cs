using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class lacrimaextractdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int Amount { get; set; }
public PropertyData Amount_Property { get; set; }
}

public class lacrimaextractdatatbl : KhazanTableBase
{
    public List<lacrimaextractdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<lacrimaextractdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<lacrimaextractdata>();
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
