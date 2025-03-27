using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class ozmadiarydata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string CategoryName { get; set; }
public PropertyData CategoryName_Property { get; set; }
    public int Diary1TIDX { get; set; }
public PropertyData Diary1TIDX_Property { get; set; }
    public string Diary1Hidden { get; set; }
public PropertyData Diary1Hidden_Property { get; set; }
    public int Diary2TIDX { get; set; }
public PropertyData Diary2TIDX_Property { get; set; }
    public string Diary2Hidden { get; set; }
public PropertyData Diary2Hidden_Property { get; set; }
    public string Diary2ImagePath { get; set; }
public PropertyData Diary2ImagePath_Property { get; set; }
    public int Diary3TIDX { get; set; }
public PropertyData Diary3TIDX_Property { get; set; }
    public string Diary3Hidden { get; set; }
public PropertyData Diary3Hidden_Property { get; set; }
    public int Diary4TIDX { get; set; }
public PropertyData Diary4TIDX_Property { get; set; }
    public string Diary4Hidden { get; set; }
public PropertyData Diary4Hidden_Property { get; set; }
}

public class ozmadiarydatatbl : KhazanTableBase
{
    public List<ozmadiarydata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<ozmadiarydata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<ozmadiarydata>();
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
