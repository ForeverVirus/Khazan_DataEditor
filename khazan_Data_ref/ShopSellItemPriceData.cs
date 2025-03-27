using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class shopsellitempricedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public string Class { get; set; }
public PropertyData Class_Property { get; set; }
    public string SubClass { get; set; }
public PropertyData SubClass_Property { get; set; }
    public int EquipmentTIDX { get; set; }
public PropertyData EquipmentTIDX_Property { get; set; }
    public int ConsumeTIDX { get; set; }
public PropertyData ConsumeTIDX_Property { get; set; }
    public int Price { get; set; }
public PropertyData Price_Property { get; set; }
}

public class shopsellitempricedatatbl : KhazanTableBase
{
    public List<shopsellitempricedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<shopsellitempricedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<shopsellitempricedata>();
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
