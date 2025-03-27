using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missionrecordbonusdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public int NeedPoint { get; set; }
public PropertyData NeedPoint_Property { get; set; }
    public int[] BalnaceOption_Slot { get; set; }
public PropertyData BalnaceOption_Slot_Property { get; set; }
}

public class missionrecordbonusdatatbl : KhazanTableBase
{
    public List<missionrecordbonusdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missionrecordbonusdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missionrecordbonusdata>();
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
