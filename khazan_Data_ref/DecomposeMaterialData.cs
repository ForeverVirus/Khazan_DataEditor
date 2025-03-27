using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class Material : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int Type { get; set; }
public PropertyData Type_Property { get; set; }
    public int Count { get; set; }
public PropertyData Count_Property { get; set; }
}

public class decomposematerialdata : KhazanDataBase
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
    public int Exp { get; set; }
public PropertyData Exp_Property { get; set; }
    public Material[] Material { get; set; }
public PropertyData Material_Property { get; set; }
}

public class decomposematerialdatatbl : KhazanTableBase
{
    public List<decomposematerialdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<decomposematerialdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<decomposematerialdata>();
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
