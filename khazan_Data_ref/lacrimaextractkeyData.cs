using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class lacrimaextractkeydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public float Weight { get; set; }
public PropertyData Weight_Property { get; set; }
}

public class lacrimaextractkeydatatbl : KhazanTableBase
{
    public List<lacrimaextractkeydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<lacrimaextractkeydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<lacrimaextractkeydata>();
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
