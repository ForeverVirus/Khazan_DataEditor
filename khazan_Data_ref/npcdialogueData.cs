using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class npcdialogueData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int ZoneInfoTIDX { get; set; }
    public int MissionTIDX { get; set; }
    public EMissionCondition MissionCondition { get; set; }
    public string MissionSequence { get; set; }
    public int NpcDialogueCollectItemTIDX { get; set; }
    public EEndingCondition EndingCondition { get; set; }
    public int TurninPointDialogueTIDX { get; set; }
    public int NeverSeenDialogueTIDX { get; set; }
    public EMenuAbilityType MenuAbility { get; set; }
    public int NpcListTIDX { get; set; }
    public EFacialPresetType FacialType { get; set; }
    public int DialogueAnimation { get; set; }
    public EDialogueType DialogueType { get; set; }
    public string DialogueTitle { get; set; }
    public int DialogueGroup { get; set; }
    public int DialogueNo { get; set; }
    public string SpeakerName { get; set; }
    public string Dialogue { get; set; }
    public string LevelSequencePath { get; set; }
    public int NpcDialogueRewardItemTIDX { get; set; }
    public int NpcMenuSet { get; set; }
    public string OVRLipsyncSpeaker { get; set; }
    public string OVRLipsyncAssetPath { get; set; }
}

public class npcdialogueDataTbl : KhazanTableBase
{
    public List<npcdialogueData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<npcdialogueData>();
        var dataArray = array.ToObject<npcdialogueData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
