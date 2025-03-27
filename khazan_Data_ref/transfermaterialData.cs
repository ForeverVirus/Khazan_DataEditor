using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class transfermaterialdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public EItemGrade Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public EItemGrade GradeCondition { get; set; }
public PropertyData GradeCondition_Property { get; set; }
    public int GoldCost { get; set; }
public PropertyData GoldCost_Property { get; set; }
    public int[] MaterialTIDX { get; set; }
public PropertyData MaterialTIDX_Property { get; set; }
    public int[] MaterialCount { get; set; }
public PropertyData MaterialCount_Property { get; set; }
}

public class transfermaterialdatatbl : KhazanTableBase
{
    public List<transfermaterialdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<transfermaterialdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<transfermaterialdata>();
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
