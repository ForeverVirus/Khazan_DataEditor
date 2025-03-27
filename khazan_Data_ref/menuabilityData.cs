using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class menuabilityData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string AbilityName { get; set; }
    public EMenuAbilityType Ability { get; set; }
    public string IconPath { get; set; }
    public int OpenMissionTIDX { get; set; }
    public bool UnlockMissionKeep { get; set; }
    public int UnlockNPCDialogueTIDX { get; set; }
    public int UnlockPlayRound { get; set; }
    public int UnLockNPCTIDX { get; set; }
    public bool UseNewPopup { get; set; }
    public string NewPopupText { get; set; }
    public string NewPopupImgPath { get; set; }
    public int AddNameMenuAbilityTIDX { get; set; }
}

public class menuabilityDataTbl : KhazanTableBase
{
    public List<menuabilityData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<menuabilityData>();
        var dataArray = array.ToObject<menuabilityData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
