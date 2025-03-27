using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class missionrecorddata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public string Description { get; set; }
public PropertyData Description_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public int Index { get; set; }
public PropertyData Index_Property { get; set; }
    public EKazanRecodeType RecodeType { get; set; }
public PropertyData RecodeType_Property { get; set; }
    public string MissionStartImagePath { get; set; }
public PropertyData MissionStartImagePath_Property { get; set; }
    public int ConsumeTIDX { get; set; }
public PropertyData ConsumeTIDX_Property { get; set; }
    public int MissionCharacterTIDX { get; set; }
public PropertyData MissionCharacterTIDX_Property { get; set; }
    public string MotionGraphicPath { get; set; }
public PropertyData MotionGraphicPath_Property { get; set; }
    public string MotionGraphicThumbnailImagePath { get; set; }
public PropertyData MotionGraphicThumbnailImagePath_Property { get; set; }
    public string MotionGraphicStoryText { get; set; }
public PropertyData MotionGraphicStoryText_Property { get; set; }
    public string UnlockRTC { get; set; }
public PropertyData UnlockRTC_Property { get; set; }
    public string RTCStoryText { get; set; }
public PropertyData RTCStoryText_Property { get; set; }
    public string RTCStoryImagePath { get; set; }
public PropertyData RTCStoryImagePath_Property { get; set; }
    public string MissionStoryText { get; set; }
public PropertyData MissionStoryText_Property { get; set; }
    public string EndingStoryText1 { get; set; }
public PropertyData EndingStoryText1_Property { get; set; }
    public string EndingStoryText2 { get; set; }
public PropertyData EndingStoryText2_Property { get; set; }
    public string EndingStoryText3 { get; set; }
public PropertyData EndingStoryText3_Property { get; set; }
    public string[] EndingStoryImagePath { get; set; }
public PropertyData EndingStoryImagePath_Property { get; set; }
}

public class missionrecorddatatbl : KhazanTableBase
{
    public List<missionrecorddata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<missionrecorddata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<missionrecorddata>();
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
