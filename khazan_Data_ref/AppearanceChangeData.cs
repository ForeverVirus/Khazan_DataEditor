using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class appearancechangedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int ListOrder { get; set; }
public PropertyData ListOrder_Property { get; set; }
    public int EquipmentTIDX { get; set; }
public PropertyData EquipmentTIDX_Property { get; set; }
    public EItemSubType SubType { get; set; }
public PropertyData SubType_Property { get; set; }
    public bool CheckAcquirement { get; set; }
public PropertyData CheckAcquirement_Property { get; set; }
}

public class appearancechangedatatbl : KhazanTableBase
{
    public List<appearancechangedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<appearancechangedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<appearancechangedata>();
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
