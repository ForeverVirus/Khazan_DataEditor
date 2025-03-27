using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class itemfactorydetaildata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public string Class { get; set; }
public PropertyData Class_Property { get; set; }
    public string SubClass { get; set; }
public PropertyData SubClass_Property { get; set; }
    public long ID { get; set; }
public PropertyData ID_Property { get; set; }
    public int Ratio { get; set; }
public PropertyData Ratio_Property { get; set; }
    public bool FixedDrop { get; set; }
public PropertyData FixedDrop_Property { get; set; }
}

public class itemfactorydetaildatatbl : KhazanTableBase
{
    public List<itemfactorydetaildata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<itemfactorydetaildata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<itemfactorydetaildata>();
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
