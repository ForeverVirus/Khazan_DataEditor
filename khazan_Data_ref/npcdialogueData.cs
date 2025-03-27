using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class npcdialoguedata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int ZoneInfoTIDX { get; set; }
public PropertyData ZoneInfoTIDX_Property { get; set; }
    public int MissionTIDX { get; set; }
public PropertyData MissionTIDX_Property { get; set; }
    public EMissionCondition MissionCondition { get; set; }
public PropertyData MissionCondition_Property { get; set; }
    public string MissionSequence { get; set; }
public PropertyData MissionSequence_Property { get; set; }
    public int NpcDialogueCollectItemTIDX { get; set; }
public PropertyData NpcDialogueCollectItemTIDX_Property { get; set; }
    public EEndingCondition EndingCondition { get; set; }
public PropertyData EndingCondition_Property { get; set; }
    public int TurninPointDialogueTIDX { get; set; }
public PropertyData TurninPointDialogueTIDX_Property { get; set; }
    public int NeverSeenDialogueTIDX { get; set; }
public PropertyData NeverSeenDialogueTIDX_Property { get; set; }
    public EMenuAbilityType MenuAbility { get; set; }
public PropertyData MenuAbility_Property { get; set; }
    public int NpcListTIDX { get; set; }
public PropertyData NpcListTIDX_Property { get; set; }
    public EFacialPresetType FacialType { get; set; }
public PropertyData FacialType_Property { get; set; }
    public int DialogueAnimation { get; set; }
public PropertyData DialogueAnimation_Property { get; set; }
    public EDialogueType DialogueType { get; set; }
public PropertyData DialogueType_Property { get; set; }
    public string DialogueTitle { get; set; }
public PropertyData DialogueTitle_Property { get; set; }
    public int DialogueGroup { get; set; }
public PropertyData DialogueGroup_Property { get; set; }
    public int DialogueNo { get; set; }
public PropertyData DialogueNo_Property { get; set; }
    public string SpeakerName { get; set; }
public PropertyData SpeakerName_Property { get; set; }
    public string Dialogue { get; set; }
public PropertyData Dialogue_Property { get; set; }
    public string LevelSequencePath { get; set; }
public PropertyData LevelSequencePath_Property { get; set; }
    public int NpcDialogueRewardItemTIDX { get; set; }
public PropertyData NpcDialogueRewardItemTIDX_Property { get; set; }
    public int NpcMenuSet { get; set; }
public PropertyData NpcMenuSet_Property { get; set; }
    public string OVRLipsyncSpeaker { get; set; }
public PropertyData OVRLipsyncSpeaker_Property { get; set; }
    public string OVRLipsyncAssetPath { get; set; }
public PropertyData OVRLipsyncAssetPath_Property { get; set; }
}

public class npcdialoguedatatbl : KhazanTableBase
{
    public List<npcdialoguedata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<npcdialoguedata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<npcdialoguedata>();
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
