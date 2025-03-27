using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class PhantomGainData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EPhantomType PhantomType { get; set; }
    public string Name { get; set; }
    public EPhantomGain GainType { get; set; }
    public int UnLockMissionTIDX { get; set; }
    public int UnlockNpcDialogue { get; set; }
    public int UnlockPlayerLevel { get; set; }
    public int UnlockSequenceDialogue { get; set; }
    public int PhantomGainSystemMessageKey { get; set; }
    public int PhantomOpenSystemMessageTIDX { get; set; }
    public string GainText { get; set; }
    public string ImagePath { get; set; }
    public string EquipmentImagePath { get; set; }
    public string BigImagePath { get; set; }
    public string StoryText { get; set; }
    public int EquipSequenceDialogue { get; set; }
    public int FriendshipItemTIDX { get; set; }
    public int NeedItemCountLevel1 { get; set; }
    public int EffectSkillLevel1 { get; set; }
    public string EffectSkilDescriptionlLevel1 { get; set; }
    public int SequenceDialogueTIDXLevel1 { get; set; }
    public int NeedItemCountLevel2 { get; set; }
    public int EffectSkillLevel2 { get; set; }
    public string EffectSkilDescriptionlLevel2 { get; set; }
    public int SequenceDialogueTIDXLevel2 { get; set; }
}

public class PhantomGainDataTbl : KhazanTableBase
{
    public List<PhantomGainData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<PhantomGainData>();
        var dataArray = array.ToObject<PhantomGainData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
