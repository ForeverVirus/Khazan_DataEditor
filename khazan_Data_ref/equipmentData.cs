using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class equipmentData : KhazanDataBase
{
    public int TIDX { get; set; }
    public Base Base { get; set; }
    public EItemTier Tier { get; set; }
    public int ProportionOption1TIDX { get; set; }
    public int ProportionOption2TIDX { get; set; }
    public int EquipLevelGroupTIDX { get; set; }
    public EGrBaseStatus Stat1ID { get; set; }
    public int Stat1Value { get; set; }
    public EGrBaseStatus Stat2ID { get; set; }
    public int Stat2Value { get; set; }
    public EGrBaseStatus UnlockStat1ID { get; set; }
    public int UnlockStat1Value { get; set; }
    public EGrBaseStatus UnlockStat2ID { get; set; }
    public int UnlockStat2Value { get; set; }
    public string InherentStat1Name { get; set; }
    public int InherentOption1TIDX { get; set; }
    public string InherentStat2Name { get; set; }
    public int InherentOption2TIDX { get; set; }
    public string InherentStat3Name { get; set; }
    public int InherentOption3TIDX { get; set; }
    public EItemGrade InherentOption1Grade { get; set; }
    public EItemGrade InherentOption2Grade { get; set; }
    public EItemGrade InherentOption3Grade { get; set; }
    public int FireDefence { get; set; }
    public int WaterDefence { get; set; }
    public int ElectricDefence { get; set; }
    public int EarthDefence { get; set; }
    public int PoisonDefence { get; set; }
    public int DiseaseDefence { get; set; }
    public int ChaosDefence { get; set; }
    public int SetItemTIDX { get; set; }
    public string Look_Mesh { get; set; }
    public string Look_Animation { get; set; }
    public float EquipWeight { get; set; }
    public EItemGrade FixedGrade { get; set; }
}

public class equipmentDataTbl : KhazanTableBase
{
    public List<equipmentData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<equipmentData>();
        var dataArray = array.ToObject<equipmentData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
