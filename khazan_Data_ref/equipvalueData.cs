using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equipvaluedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EItemType Type { get; set; }
public PropertyData Type_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public int Value { get; set; }
public PropertyData Value_Property { get; set; }
    public int WeightValue { get; set; }
public PropertyData WeightValue_Property { get; set; }
}

public class equipvaluedatatbl : KhazanTableBase
{
    public List<equipvaluedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equipvaluedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equipvaluedata>();
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
