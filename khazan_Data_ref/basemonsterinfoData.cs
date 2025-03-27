using Newtonsoft.Json.Linq;

namespace KhazanData
{
public class Status : KhazanDataBase
{
    public int TIDX { get; set; }
    public long StaminaPointMax { get; set; }
    public int STRecovery { get; set; }
    public int SkillPoint { get; set; }
    public int Power { get; set; }
    public int DamageReductionRate { get; set; }
    public int PowerBonus { get; set; }
    public int DamageRate { get; set; }
    public int SkillDamageRate { get; set; }
    public int DamageAddRate { get; set; }
    public int GuardPenetrateRate { get; set; }
    public int BackAttackDamageRate { get; set; }
    public int ExhaustDamageRate { get; set; }
    public int AttackAndDefense { get; set; }
    public int Defense { get; set; }
    public int DefenseBonus { get; set; }
    public int DamageHalfReductionRate { get; set; }
    public int DefenseReductionValue { get; set; }
    public int DefenseReductionValuePerLevel { get; set; }
    public int StaminaDamage { get; set; }
    public int StaminaDamageRate { get; set; }
    public int ParryStaminaReduction { get; set; }
    public int StaminaDamageReductionRate { get; set; }
    public int GuardStaminaReductionRate { get; set; }
    public int GuardStaminaKeepRate { get; set; }
    public int StaminaReductionRate { get; set; }
    public int HPPosionLifeRecoveryRate { get; set; }
    public int HPPosionCount { get; set; }
    public int StaminaPosionCount { get; set; }
    public int DaggerCount { get; set; }
    public int JavelinCount { get; set; }
    public int Body { get; set; }
    public int Heart { get; set; }
    public int Strength { get; set; }
    public int Force { get; set; }
    public int Skill { get; set; }
    public long HealthPointMax { get; set; }
    public int HealthPointMaxBonus { get; set; }
    public int FireAttack { get; set; }
    public int WaterAttack { get; set; }
    public int ElectricAttack { get; set; }
    public int EarthAttack { get; set; }
    public int PoisonAttack { get; set; }
    public int DeseaseAttack { get; set; }
    public int ChaosAttack { get; set; }
    public int ElementalResistDark { get; set; }
    public int FireDefense { get; set; }
    public int WaterDefense { get; set; }
    public int ElectricDefense { get; set; }
    public int EarthDefense { get; set; }
    public int PoisonDefense { get; set; }
    public int DeseaseDefense { get; set; }
    public int ChaosDefense { get; set; }
    public int STRecoveryTime { get; set; }
    public int BattleResourceMaxGroup1 { get; set; }
    public int BattleResourceMaxGroup2 { get; set; }
    public int BattleResourceMaxGroup3 { get; set; }
    public int BattleResourceMaxGroup4 { get; set; }
    public int BattleResourceMaxGroup5 { get; set; }
    public int BattleResourceMaxGroup6 { get; set; }
    public int BattleResourceMaxGroup7 { get; set; }
    public int BattleResourceMaxGroup8 { get; set; }
    public float EquipWeightMax { get; set; }
    public int AttackerReaction { get; set; }
    public int DamagerReaction { get; set; }
    public int AmountLacrima { get; set; }
    public int WeaponDropRate { get; set; }
    public int HealthPotionDropRate { get; set; }
    public int IncreaseItemRank { get; set; }
    public int IncreasePhentomDuration { get; set; }
    public int AmountGold { get; set; }
    public int DefensePenetrate { get; set; }
    public int SetCount { get; set; }
    public int IncreaseBodyLv { get; set; }
    public int IncreaseHeartLv { get; set; }
    public int IncreaseStrengthLv { get; set; }
    public int IncreaseForceLv { get; set; }
    public int IncreaseSkillLv { get; set; }
    public int BrutalDamageRate { get; set; }
    public int BattleResource1GainRate { get; set; }
    public int BattleResource5GainRate { get; set; }
    public int AllyAPCHealthPointMax { get; set; }
    public int AllyAPCDamageRate { get; set; }
    public int AllyAPCStaminaPointMax { get; set; }
    public int AttributeDebuffGauge { get; set; }
    public int BattleResource1GainRateWhenJustGuard { get; set; }
}

public class basemonsterinfoData : KhazanDataBase
{
    public int TIDX { get; set; }
    public int GroupIndex { get; set; }
    public int Level { get; set; }
    public string Tag { get; set; }
    public int Tag2 { get; set; }
    public EActorGradeType Grade { get; set; }
    public Status Status { get; set; }
}

public class basemonsterinfoDataTbl : KhazanTableBase
{
    public List<basemonsterinfoData> Table { get; set; }
    public void Initialize(JArray array)
    {
        Table = new List<basemonsterinfoData>();
        var dataArray = array.ToObject<basemonsterinfoData[]>();
        Table.AddRange(dataArray);
    }

    public override List<KhazanDataBase> GetTable()
    {
        return new List<KhazanDataBase>(Table);
    }
}
}
