using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class equiplevelgroupdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public int EquipLevelGroup { get; set; }
public PropertyData EquipLevelGroup_Property { get; set; }
    public int EquipLevel { get; set; }
public PropertyData EquipLevel_Property { get; set; }
    public int BaseStatMin { get; set; }
public PropertyData BaseStatMin_Property { get; set; }
    public int BaseStatMax { get; set; }
public PropertyData BaseStatMax_Property { get; set; }
}

public class equiplevelgroupdatatbl : KhazanTableBase
{
    public List<equiplevelgroupdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<equiplevelgroupdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<equiplevelgroupdata>();
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
