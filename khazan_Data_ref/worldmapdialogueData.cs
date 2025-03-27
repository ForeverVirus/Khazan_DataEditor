using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class worldmapdialoguedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EWorldmapDialogueType OutputType { get; set; }
public PropertyData OutputType_Property { get; set; }
    public long OutputTIDX { get; set; }
public PropertyData OutputTIDX_Property { get; set; }
    public string LeftNpcName { get; set; }
public PropertyData LeftNpcName_Property { get; set; }
    public string LeftNpcImgPath { get; set; }
public PropertyData LeftNpcImgPath_Property { get; set; }
    public string RightNpcName { get; set; }
public PropertyData RightNpcName_Property { get; set; }
    public string RightNpcImgPath { get; set; }
public PropertyData RightNpcImgPath_Property { get; set; }
    public EWorldmapDialogueSpeaker DialogueSpeaker { get; set; }
public PropertyData DialogueSpeaker_Property { get; set; }
    public string Dialogue { get; set; }
public PropertyData Dialogue_Property { get; set; }
}

public class worldmapdialoguedatatbl : KhazanTableBase
{
    public List<worldmapdialoguedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<worldmapdialoguedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<worldmapdialoguedata>();
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
