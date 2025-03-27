using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class masterybonusdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int MasteryLevel { get; set; }
public PropertyData MasteryLevel_Property { get; set; }
    public int LevelupMasteryPoint { get; set; }
public PropertyData LevelupMasteryPoint_Property { get; set; }
    public int LevelupCommonMasteryPoint { get; set; }
public PropertyData LevelupCommonMasteryPoint_Property { get; set; }
}

public class masterybonusdatatbl : KhazanTableBase
{
    public List<masterybonusdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<masterybonusdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<masterybonusdata>();
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
