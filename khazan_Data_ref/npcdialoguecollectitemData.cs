using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class CollectItemInfo : KhazanDataBase
{
    public int CollectItemTIDX { get; set; }
public PropertyData CollectItemTIDX_Property { get; set; }
    public int CollectItemCount { get; set; }
public PropertyData CollectItemCount_Property { get; set; }
}

public class npcdialoguecollectitemdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public bool IsReturn { get; set; }
public PropertyData IsReturn_Property { get; set; }
    public CollectItemInfo[] CollectItemInfo { get; set; }
public PropertyData CollectItemInfo_Property { get; set; }
}

public class npcdialoguecollectitemdatatbl : KhazanTableBase
{
    public List<npcdialoguecollectitemdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<npcdialoguecollectitemdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<npcdialoguecollectitemdata>();
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
