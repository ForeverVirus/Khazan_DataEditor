using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class AttributeCorrectionInfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public EKazanWeaponType SubType { get; set; }
    public int FireCorrectionRate { get; set; }
    public int WaterCorrectionRate { get; set; }
    public int ElectricCorrectionRate { get; set; }
    public int EarthCorrectionRate { get; set; }
    public int PoisonCorrectionRate { get; set; }
    public int DeseaseCorrectionRate { get; set; }
    public int ChaosCorrectionRate { get; set; }
    public int FireCorrectionAccrueRate { get; set; }
    public int WaterCorrectionAccrueRate { get; set; }
    public int ElectricCorrectionAccrueRate { get; set; }
    public int EarthCorrectionAccrueRate { get; set; }
    public int PoisonCorrectionAccrueRate { get; set; }
    public int DeseaseCorrectionAccrueRate { get; set; }
    public int ChaosCorrectionAccrueRate { get; set; }
}

public class AttributeCorrectionInfoDataTbl : KhazanTableBase
{
    public List<AttributeCorrectionInfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<AttributeCorrectionInfoData>();
        var dataArray = array.ToObject<AttributeCorrectionInfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
