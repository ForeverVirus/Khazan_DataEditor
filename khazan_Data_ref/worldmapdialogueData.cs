using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class worldmapdialogueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EWorldmapDialogueType OutputType { get; set; }
    public long OutputTIDX { get; set; }
    public string LeftNpcName { get; set; }
    public string LeftNpcImgPath { get; set; }
    public string RightNpcName { get; set; }
    public string RightNpcImgPath { get; set; }
    public EWorldmapDialogueSpeaker DialogueSpeaker { get; set; }
    public string Dialogue { get; set; }
}

public class worldmapdialogueDataTbl : KhazanTableBase
{
    public List<worldmapdialogueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<worldmapdialogueData>();
        var dataArray = array.ToObject<worldmapdialogueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
