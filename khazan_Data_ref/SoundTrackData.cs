using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class SoundTrackData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Name { get; set; }
    public string SoundStartPath { get; set; }
    public string SoundEndPath { get; set; }
    public string SoundPausePath { get; set; }
    public string SoundResumePath { get; set; }
    public string ImagePath { get; set; }
}

public class SoundTrackDataTbl : KhazanTableBase
{
    public List<SoundTrackData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<SoundTrackData>();
        var dataArray = array.ToObject<SoundTrackData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
