using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class npclistdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string Blueprint { get; set; }
public PropertyData Blueprint_Property { get; set; }
    public int NpcMenuTIDX { get; set; }
public PropertyData NpcMenuTIDX_Property { get; set; }
}

public class npclistdatatbl : KhazanTableBase
{
    public List<npclistdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<npclistdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<npclistdata>();
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
