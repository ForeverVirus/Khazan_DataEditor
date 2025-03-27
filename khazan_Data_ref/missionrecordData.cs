using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class missionrecordData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int GroupIndex { get; set; }
    public int MissionTIDX { get; set; }
    public int Index { get; set; }
    public EKazanRecodeType RecodeType { get; set; }
    public string MissionStartImagePath { get; set; }
    public int ConsumeTIDX { get; set; }
    public int MissionCharacterTIDX { get; set; }
    public string MotionGraphicPath { get; set; }
    public string MotionGraphicThumbnailImagePath { get; set; }
    public string MotionGraphicStoryText { get; set; }
    public string UnlockRTC { get; set; }
    public string RTCStoryText { get; set; }
    public string RTCStoryImagePath { get; set; }
    public string MissionStoryText { get; set; }
    public string EndingStoryText1 { get; set; }
    public string EndingStoryText2 { get; set; }
    public string EndingStoryText3 { get; set; }
    public string[] EndingStoryImagePath { get; set; }
}

public class missionrecordDataTbl : KhazanTableBase
{
    public List<missionrecordData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<missionrecordData>();
        var dataArray = array.ToObject<missionrecordData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
