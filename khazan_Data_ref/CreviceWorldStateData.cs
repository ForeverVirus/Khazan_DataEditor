using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class creviceworldstatedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public ECreviceWorldState CreviceWorldState { get; set; }
public PropertyData CreviceWorldState_Property { get; set; }
    public string Desc { get; set; }
public PropertyData Desc_Property { get; set; }
    public int NpcListTIDX { get; set; }
public PropertyData NpcListTIDX_Property { get; set; }
    public int ObjectListTIDX { get; set; }
public PropertyData ObjectListTIDX_Property { get; set; }
    public string LevelPackageName { get; set; }
public PropertyData LevelPackageName_Property { get; set; }
    public string WEP { get; set; }
public PropertyData WEP_Property { get; set; }
}

public class creviceworldstatedatatbl : KhazanTableBase
{
    public List<creviceworldstatedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<creviceworldstatedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<creviceworldstatedata>();
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
