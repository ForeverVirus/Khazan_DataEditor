using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class Effect : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public int SetCount { get; set; }
public PropertyData SetCount_Property { get; set; }
    public int OptionTIDX { get; set; }
public PropertyData OptionTIDX_Property { get; set; }
    public string Image { get; set; }
public PropertyData Image_Property { get; set; }
}

public class setitemdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string CraftingImage { get; set; }
public PropertyData CraftingImage_Property { get; set; }
    public int CraftingOrder { get; set; }
public PropertyData CraftingOrder_Property { get; set; }
    public Effect[] Effect { get; set; }
public PropertyData Effect_Property { get; set; }
}

public class setitemdatatbl : KhazanTableBase
{
    public List<setitemdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<setitemdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<setitemdata>();
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
