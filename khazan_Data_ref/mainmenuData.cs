using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class mainmenuData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EMainMenuType MainMenuType { get; set; }
    public string Name { get; set; }
    public string MenuDesc { get; set; }
    public int UnLockMissionTIDX { get; set; }
    public int UnLockSkillPoint { get; set; }
    public int UnLockNPCTIDX { get; set; }
    public ETutorialType UnLockTutorialType { get; set; }
    public bool UseNewPopup { get; set; }
    public string NewPopupText { get; set; }
    public string NewPopupImgPath { get; set; }
}

public class mainmenuDataTbl : KhazanTableBase
{
    public List<mainmenuData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<mainmenuData>();
        var dataArray = array.ToObject<mainmenuData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
