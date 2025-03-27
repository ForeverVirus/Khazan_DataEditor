using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class soundtrackdata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public string SoundStartPath { get; set; }
public PropertyData SoundStartPath_Property { get; set; }
    public string SoundEndPath { get; set; }
public PropertyData SoundEndPath_Property { get; set; }
    public string SoundPausePath { get; set; }
public PropertyData SoundPausePath_Property { get; set; }
    public string SoundResumePath { get; set; }
public PropertyData SoundResumePath_Property { get; set; }
    public string ImagePath { get; set; }
public PropertyData ImagePath_Property { get; set; }
}

public class soundtrackdatatbl : KhazanTableBase
{
    public List<soundtrackdata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<soundtrackdata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<soundtrackdata>();
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
