using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class craftingcostdata : KhazanDataBase
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
    public int ConsumeTIDX { get; set; }
public PropertyData ConsumeTIDX_Property { get; set; }
    public int EquipmentTIDX { get; set; }
public PropertyData EquipmentTIDX_Property { get; set; }
    public int GoldCost { get; set; }
public PropertyData GoldCost_Property { get; set; }
    public int Material1TIDX { get; set; }
public PropertyData Material1TIDX_Property { get; set; }
    public int Material1Count { get; set; }
public PropertyData Material1Count_Property { get; set; }
    public int Material2TIDX { get; set; }
public PropertyData Material2TIDX_Property { get; set; }
    public int Material2Count { get; set; }
public PropertyData Material2Count_Property { get; set; }
    public int Material3TIDX { get; set; }
public PropertyData Material3TIDX_Property { get; set; }
    public int Material3Count { get; set; }
public PropertyData Material3Count_Property { get; set; }
    public int Material4TIDX { get; set; }
public PropertyData Material4TIDX_Property { get; set; }
    public int Material4Count { get; set; }
public PropertyData Material4Count_Property { get; set; }
    public int Material5TIDX { get; set; }
public PropertyData Material5TIDX_Property { get; set; }
    public int Material5Count { get; set; }
public PropertyData Material5Count_Property { get; set; }
    public int Material6TIDX { get; set; }
public PropertyData Material6TIDX_Property { get; set; }
    public int Material6Count { get; set; }
public PropertyData Material6Count_Property { get; set; }
}

public class craftingcostdatatbl : KhazanTableBase
{
    public List<craftingcostdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<craftingcostdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<craftingcostdata>();
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
