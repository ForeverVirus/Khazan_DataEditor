using UAssetAPI;
using UAssetAPI.ExportTypes;
using UAssetAPI.PropertyTypes.Objects;

namespace KhazanData
{
public class Status : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public long StaminaPointMax { get; set; }
public PropertyData StaminaPointMax_Property { get; set; }
    public int STRecovery { get; set; }
public PropertyData STRecovery_Property { get; set; }
    public int SkillPoint { get; set; }
public PropertyData SkillPoint_Property { get; set; }
    public int Power { get; set; }
public PropertyData Power_Property { get; set; }
    public int DamageReductionRate { get; set; }
public PropertyData DamageReductionRate_Property { get; set; }
    public int PowerBonus { get; set; }
public PropertyData PowerBonus_Property { get; set; }
    public int DamageRate { get; set; }
public PropertyData DamageRate_Property { get; set; }
    public int SkillDamageRate { get; set; }
public PropertyData SkillDamageRate_Property { get; set; }
    public int DamageAddRate { get; set; }
public PropertyData DamageAddRate_Property { get; set; }
    public int GuardPenetrateRate { get; set; }
public PropertyData GuardPenetrateRate_Property { get; set; }
    public int BackAttackDamageRate { get; set; }
public PropertyData BackAttackDamageRate_Property { get; set; }
    public int ExhaustDamageRate { get; set; }
public PropertyData ExhaustDamageRate_Property { get; set; }
    public int AttackAndDefense { get; set; }
public PropertyData AttackAndDefense_Property { get; set; }
    public int Defense { get; set; }
public PropertyData Defense_Property { get; set; }
    public int DefenseBonus { get; set; }
public PropertyData DefenseBonus_Property { get; set; }
    public int DamageHalfReductionRate { get; set; }
public PropertyData DamageHalfReductionRate_Property { get; set; }
    public int DefenseReductionValue { get; set; }
public PropertyData DefenseReductionValue_Property { get; set; }
    public int DefenseReductionValuePerLevel { get; set; }
public PropertyData DefenseReductionValuePerLevel_Property { get; set; }
    public int StaminaDamage { get; set; }
public PropertyData StaminaDamage_Property { get; set; }
    public int StaminaDamageRate { get; set; }
public PropertyData StaminaDamageRate_Property { get; set; }
    public int ParryStaminaReduction { get; set; }
public PropertyData ParryStaminaReduction_Property { get; set; }
    public int StaminaDamageReductionRate { get; set; }
public PropertyData StaminaDamageReductionRate_Property { get; set; }
    public int GuardStaminaReductionRate { get; set; }
public PropertyData GuardStaminaReductionRate_Property { get; set; }
    public int GuardStaminaKeepRate { get; set; }
public PropertyData GuardStaminaKeepRate_Property { get; set; }
    public int StaminaReductionRate { get; set; }
public PropertyData StaminaReductionRate_Property { get; set; }
    public int HPPosionLifeRecoveryRate { get; set; }
public PropertyData HPPosionLifeRecoveryRate_Property { get; set; }
    public int HPPosionCount { get; set; }
public PropertyData HPPosionCount_Property { get; set; }
    public int StaminaPosionCount { get; set; }
public PropertyData StaminaPosionCount_Property { get; set; }
    public int DaggerCount { get; set; }
public PropertyData DaggerCount_Property { get; set; }
    public int JavelinCount { get; set; }
public PropertyData JavelinCount_Property { get; set; }
    public int Body { get; set; }
public PropertyData Body_Property { get; set; }
    public int Heart { get; set; }
public PropertyData Heart_Property { get; set; }
    public int Strength { get; set; }
public PropertyData Strength_Property { get; set; }
    public int Force { get; set; }
public PropertyData Force_Property { get; set; }
    public int Skill { get; set; }
public PropertyData Skill_Property { get; set; }
    public long HealthPointMax { get; set; }
public PropertyData HealthPointMax_Property { get; set; }
    public int HealthPointMaxBonus { get; set; }
public PropertyData HealthPointMaxBonus_Property { get; set; }
    public int FireAttack { get; set; }
public PropertyData FireAttack_Property { get; set; }
    public int WaterAttack { get; set; }
public PropertyData WaterAttack_Property { get; set; }
    public int ElectricAttack { get; set; }
public PropertyData ElectricAttack_Property { get; set; }
    public int EarthAttack { get; set; }
public PropertyData EarthAttack_Property { get; set; }
    public int PoisonAttack { get; set; }
public PropertyData PoisonAttack_Property { get; set; }
    public int DeseaseAttack { get; set; }
public PropertyData DeseaseAttack_Property { get; set; }
    public int ChaosAttack { get; set; }
public PropertyData ChaosAttack_Property { get; set; }
    public int ElementalResistDark { get; set; }
public PropertyData ElementalResistDark_Property { get; set; }
    public int FireDefense { get; set; }
public PropertyData FireDefense_Property { get; set; }
    public int WaterDefense { get; set; }
public PropertyData WaterDefense_Property { get; set; }
    public int ElectricDefense { get; set; }
public PropertyData ElectricDefense_Property { get; set; }
    public int EarthDefense { get; set; }
public PropertyData EarthDefense_Property { get; set; }
    public int PoisonDefense { get; set; }
public PropertyData PoisonDefense_Property { get; set; }
    public int DeseaseDefense { get; set; }
public PropertyData DeseaseDefense_Property { get; set; }
    public int ChaosDefense { get; set; }
public PropertyData ChaosDefense_Property { get; set; }
    public int STRecoveryTime { get; set; }
public PropertyData STRecoveryTime_Property { get; set; }
    public int BattleResourceMaxGroup1 { get; set; }
public PropertyData BattleResourceMaxGroup1_Property { get; set; }
    public int BattleResourceMaxGroup2 { get; set; }
public PropertyData BattleResourceMaxGroup2_Property { get; set; }
    public int BattleResourceMaxGroup3 { get; set; }
public PropertyData BattleResourceMaxGroup3_Property { get; set; }
    public int BattleResourceMaxGroup4 { get; set; }
public PropertyData BattleResourceMaxGroup4_Property { get; set; }
    public int BattleResourceMaxGroup5 { get; set; }
public PropertyData BattleResourceMaxGroup5_Property { get; set; }
    public int BattleResourceMaxGroup6 { get; set; }
public PropertyData BattleResourceMaxGroup6_Property { get; set; }
    public int BattleResourceMaxGroup7 { get; set; }
public PropertyData BattleResourceMaxGroup7_Property { get; set; }
    public int BattleResourceMaxGroup8 { get; set; }
public PropertyData BattleResourceMaxGroup8_Property { get; set; }
    public float EquipWeightMax { get; set; }
public PropertyData EquipWeightMax_Property { get; set; }
    public int AttackerReaction { get; set; }
public PropertyData AttackerReaction_Property { get; set; }
    public int DamagerReaction { get; set; }
public PropertyData DamagerReaction_Property { get; set; }
    public int AmountLacrima { get; set; }
public PropertyData AmountLacrima_Property { get; set; }
    public int WeaponDropRate { get; set; }
public PropertyData WeaponDropRate_Property { get; set; }
    public int HealthPotionDropRate { get; set; }
public PropertyData HealthPotionDropRate_Property { get; set; }
    public int IncreaseItemRank { get; set; }
public PropertyData IncreaseItemRank_Property { get; set; }
    public int IncreasePhentomDuration { get; set; }
public PropertyData IncreasePhentomDuration_Property { get; set; }
    public int AmountGold { get; set; }
public PropertyData AmountGold_Property { get; set; }
    public int DefensePenetrate { get; set; }
public PropertyData DefensePenetrate_Property { get; set; }
    public int SetCount { get; set; }
public PropertyData SetCount_Property { get; set; }
    public int IncreaseBodyLv { get; set; }
public PropertyData IncreaseBodyLv_Property { get; set; }
    public int IncreaseHeartLv { get; set; }
public PropertyData IncreaseHeartLv_Property { get; set; }
    public int IncreaseStrengthLv { get; set; }
public PropertyData IncreaseStrengthLv_Property { get; set; }
    public int IncreaseForceLv { get; set; }
public PropertyData IncreaseForceLv_Property { get; set; }
    public int IncreaseSkillLv { get; set; }
public PropertyData IncreaseSkillLv_Property { get; set; }
    public int BrutalDamageRate { get; set; }
public PropertyData BrutalDamageRate_Property { get; set; }
    public int BattleResource1GainRate { get; set; }
public PropertyData BattleResource1GainRate_Property { get; set; }
    public int BattleResource5GainRate { get; set; }
public PropertyData BattleResource5GainRate_Property { get; set; }
    public int AllyAPCHealthPointMax { get; set; }
public PropertyData AllyAPCHealthPointMax_Property { get; set; }
    public int AllyAPCDamageRate { get; set; }
public PropertyData AllyAPCDamageRate_Property { get; set; }
    public int AllyAPCStaminaPointMax { get; set; }
public PropertyData AllyAPCStaminaPointMax_Property { get; set; }
    public int AttributeDebuffGauge { get; set; }
public PropertyData AttributeDebuffGauge_Property { get; set; }
    public int BattleResource1GainRateWhenJustGuard { get; set; }
public PropertyData BattleResource1GainRateWhenJustGuard_Property { get; set; }
}

public class basemonsterinfodata : KhazanDataBase
{
    public int TIDX { get; set; }
public PropertyData TIDX_Property { get; set; }
    public int GroupIndex { get; set; }
public PropertyData GroupIndex_Property { get; set; }
    public int Level { get; set; }
public PropertyData Level_Property { get; set; }
    public string Tag { get; set; }
public PropertyData Tag_Property { get; set; }
    public int Tag2 { get; set; }
public PropertyData Tag2_Property { get; set; }
    public EActorGradeType Grade { get; set; }
public PropertyData Grade_Property { get; set; }
    public Status Status { get; set; }
public PropertyData Status_Property { get; set; }
}

public class basemonsterinfodatatbl : KhazanTableBase
{
    public List<basemonsterinfodata> Table
    {
        get { return _table;}
        set { _table = value; }
    }
    private List<basemonsterinfodata> _table;
    public override void Initialize(UAsset uasset)
    {
        _table = new List<basemonsterinfodata>();
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
