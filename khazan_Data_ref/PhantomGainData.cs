using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class phantomgaindata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public EPhantomType PhantomType { get; set; }
public PropertyData PhantomType_Property { get; set; }
    public string Name { get; set; }
public PropertyData Name_Property { get; set; }
    public EPhantomGain GainType { get; set; }
public PropertyData GainType_Property { get; set; }
    public int UnLockMissionTIDX { get; set; }
public PropertyData UnLockMissionTIDX_Property { get; set; }
    public int UnlockNpcDialogue { get; set; }
public PropertyData UnlockNpcDialogue_Property { get; set; }
    public int UnlockPlayerLevel { get; set; }
public PropertyData UnlockPlayerLevel_Property { get; set; }
    public int UnlockSequenceDialogue { get; set; }
public PropertyData UnlockSequenceDialogue_Property { get; set; }
    public int PhantomGainSystemMessageKey { get; set; }
public PropertyData PhantomGainSystemMessageKey_Property { get; set; }
    public int PhantomOpenSystemMessageTIDX { get; set; }
public PropertyData PhantomOpenSystemMessageTIDX_Property { get; set; }
    public string GainText { get; set; }
public PropertyData GainText_Property { get; set; }
    public string ImagePath { get; set; }
public PropertyData ImagePath_Property { get; set; }
    public string EquipmentImagePath { get; set; }
public PropertyData EquipmentImagePath_Property { get; set; }
    public string BigImagePath { get; set; }
public PropertyData BigImagePath_Property { get; set; }
    public string StoryText { get; set; }
public PropertyData StoryText_Property { get; set; }
    public int EquipSequenceDialogue { get; set; }
public PropertyData EquipSequenceDialogue_Property { get; set; }
    public int FriendshipItemTIDX { get; set; }
public PropertyData FriendshipItemTIDX_Property { get; set; }
    public int NeedItemCountLevel1 { get; set; }
public PropertyData NeedItemCountLevel1_Property { get; set; }
    public int EffectSkillLevel1 { get; set; }
public PropertyData EffectSkillLevel1_Property { get; set; }
    public string EffectSkilDescriptionlLevel1 { get; set; }
public PropertyData EffectSkilDescriptionlLevel1_Property { get; set; }
    public string DescriptionlLevel1ReplaceText0 { get; set; }
public PropertyData DescriptionlLevel1ReplaceText0_Property { get; set; }
    public string DescriptionlLevel1ReplaceText1 { get; set; }
public PropertyData DescriptionlLevel1ReplaceText1_Property { get; set; }
    public string DescriptionlLevel1ReplaceText2 { get; set; }
public PropertyData DescriptionlLevel1ReplaceText2_Property { get; set; }
    public int SequenceDialogueTIDXLevel1 { get; set; }
public PropertyData SequenceDialogueTIDXLevel1_Property { get; set; }
    public int NeedItemCountLevel2 { get; set; }
public PropertyData NeedItemCountLevel2_Property { get; set; }
    public int EffectSkillLevel2 { get; set; }
public PropertyData EffectSkillLevel2_Property { get; set; }
    public string EffectSkilDescriptionlLevel2 { get; set; }
public PropertyData EffectSkilDescriptionlLevel2_Property { get; set; }
    public string DescriptionlLevel2ReplaceText0 { get; set; }
public PropertyData DescriptionlLevel2ReplaceText0_Property { get; set; }
    public string DescriptionlLevel2ReplaceText1 { get; set; }
public PropertyData DescriptionlLevel2ReplaceText1_Property { get; set; }
    public string DescriptionlLevel2ReplaceText2 { get; set; }
public PropertyData DescriptionlLevel2ReplaceText2_Property { get; set; }
    public int SequenceDialogueTIDXLevel2 { get; set; }
public PropertyData SequenceDialogueTIDXLevel2_Property { get; set; }
}

public class phantomgaindatatbl : KhazanTableBase
{
    public List<phantomgaindata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<phantomgaindata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<phantomgaindata>();
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
