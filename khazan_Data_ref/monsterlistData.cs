using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class monsterlistData : KhazanDataBase
{
    public int TIDX { get; set; }
    public string Tag { get; set; }
    public string Name { get; set; }
    public int BaseInfoGroupIndex { get; set; }
    public EMonsterGradeType MonsterGradeType { get; set; }
    public EMonsterRace MonsterRace { get; set; }
    public EMonsterSpecies MonsterSpecies { get; set; }
    public ENormalAttackType NormalAttackType { get; set; }
    public string Blueprint { get; set; }
    public string MiniImg { get; set; }
    public int AfterDieSpawnedActorTIDX { get; set; }
    public int FactionTIDX { get; set; }
    public EOverheadGaugeType OverHeadGaugeType { get; set; }
    public int DropRewardID { get; set; }
    public ERewardGrade MonsterRewardGrade { get; set; }
}

public class monsterlistDataTbl : KhazanTableBase
{
    public List<monsterlistData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<monsterlistData>();
        var dataArray = array.ToObject<monsterlistData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
