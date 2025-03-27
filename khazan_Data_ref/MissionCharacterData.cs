using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class MissionCharacterData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Description { get; set; }
    public int GroupIndex { get; set; }
    public string CharacterName { get; set; }
    public int MissionTIDX { get; set; }
    public int UnlockMissionStartTDIX { get; set; }
    public int UnlockConsumeTIDX { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
    public string UnlockSequence { get; set; }
    public int UnlockMissionTIDX { get; set; }
    public EEndingType UnlodckEndingType { get; set; }
    public ERelationShipType Relationship { get; set; }
    public string CharacterStory { get; set; }
    public string PortraitPath { get; set; }
    public string DetailPage_PortraitPath { get; set; }
    public int SortOrder { get; set; }
}

public class MissionCharacterDataTbl : KhazanTableBase
{
    public List<MissionCharacterData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<MissionCharacterData>();
        var dataArray = array.ToObject<MissionCharacterData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
