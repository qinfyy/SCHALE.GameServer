// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterStatExcel GetRootAsCharacterStatExcel(ByteBuffer _bb) { return GetRootAsCharacterStatExcel(_bb, new CharacterStatExcel()); }
  public static CharacterStatExcel GetRootAsCharacterStatExcel(ByteBuffer _bb, CharacterStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StabilityRate { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StabilityPoint { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower1 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower100 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP1 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP100 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePower1 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePower100 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower1 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealPower100 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DodgePoint { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AccuracyPoint { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalPoint { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalResistPoint { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalDamageRate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalDamageResistRate { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BlockRate { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long HealEffectivenessRate { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OppressionPower { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OppressionResist { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetration1 { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetration100 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetrationResist1 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePenetrationResist100 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceExplosionRate { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhancePierceRate { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceMysticRate { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceSonicRate { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceSiegeRate { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceNormalRate { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceLightArmorRate { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceHeavyArmorRate { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceUnarmedRate { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceElasticArmorRate { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceStructureRate { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnhanceNormalArmorRate { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendBuffDuration { get { int o = __p.__offset(78); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendDebuffDuration { get { int o = __p.__offset(80); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExtendCrowdControlDuration { get { int o = __p.__offset(82); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AmmoCount { get { int o = __p.__offset(84); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AmmoCost { get { int o = __p.__offset(86); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long IgnoreDelayCount { get { int o = __p.__offset(88); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NormalAttackSpeed { get { int o = __p.__offset(90); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Range { get { int o = __p.__offset(92); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long InitialRangeRate { get { int o = __p.__offset(94); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MoveSpeed { get { int o = __p.__offset(96); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SightPoint { get { int o = __p.__offset(98); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActiveGauge { get { int o = __p.__offset(100); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int GroggyGauge { get { int o = __p.__offset(102); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int GroggyTime { get { int o = __p.__offset(104); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StrategyMobility { get { int o = __p.__offset(106); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ActionCount { get { int o = __p.__offset(108); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StrategySightRange { get { int o = __p.__offset(110); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamageRatio { get { int o = __p.__offset(112); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamagedRatio { get { int o = __p.__offset(114); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamageRatio2Increase { get { int o = __p.__offset(116); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamageRatio2Decrease { get { int o = __p.__offset(118); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamagedRatio2Increase { get { int o = __p.__offset(120); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DamagedRatio2Decrease { get { int o = __p.__offset(122); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExDamagedRatioIncrease { get { int o = __p.__offset(124); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ExDamagedRatioDecrease { get { int o = __p.__offset(126); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.TerrainAdaptationStat StreetBattleAdaptation { get { int o = __p.__offset(128); return o != 0 ? (SCHALE.Common.FlatData.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TerrainAdaptationStat.D; } }
  public SCHALE.Common.FlatData.TerrainAdaptationStat OutdoorBattleAdaptation { get { int o = __p.__offset(130); return o != 0 ? (SCHALE.Common.FlatData.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TerrainAdaptationStat.D; } }
  public SCHALE.Common.FlatData.TerrainAdaptationStat IndoorBattleAdaptation { get { int o = __p.__offset(132); return o != 0 ? (SCHALE.Common.FlatData.TerrainAdaptationStat)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TerrainAdaptationStat.D; } }
  public long RegenCost { get { int o = __p.__offset(134); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.CharacterStatExcel> CreateCharacterStatExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      long StabilityRate = 0,
      long StabilityPoint = 0,
      long AttackPower1 = 0,
      long AttackPower100 = 0,
      long MaxHP1 = 0,
      long MaxHP100 = 0,
      long DefensePower1 = 0,
      long DefensePower100 = 0,
      long HealPower1 = 0,
      long HealPower100 = 0,
      long DodgePoint = 0,
      long AccuracyPoint = 0,
      long CriticalPoint = 0,
      long CriticalResistPoint = 0,
      long CriticalDamageRate = 0,
      long CriticalDamageResistRate = 0,
      long BlockRate = 0,
      long HealEffectivenessRate = 0,
      long OppressionPower = 0,
      long OppressionResist = 0,
      long DefensePenetration1 = 0,
      long DefensePenetration100 = 0,
      long DefensePenetrationResist1 = 0,
      long DefensePenetrationResist100 = 0,
      long EnhanceExplosionRate = 0,
      long EnhancePierceRate = 0,
      long EnhanceMysticRate = 0,
      long EnhanceSonicRate = 0,
      long EnhanceSiegeRate = 0,
      long EnhanceNormalRate = 0,
      long EnhanceLightArmorRate = 0,
      long EnhanceHeavyArmorRate = 0,
      long EnhanceUnarmedRate = 0,
      long EnhanceElasticArmorRate = 0,
      long EnhanceStructureRate = 0,
      long EnhanceNormalArmorRate = 0,
      long ExtendBuffDuration = 0,
      long ExtendDebuffDuration = 0,
      long ExtendCrowdControlDuration = 0,
      long AmmoCount = 0,
      long AmmoCost = 0,
      long IgnoreDelayCount = 0,
      long NormalAttackSpeed = 0,
      long Range = 0,
      long InitialRangeRate = 0,
      long MoveSpeed = 0,
      long SightPoint = 0,
      long ActiveGauge = 0,
      int GroggyGauge = 0,
      int GroggyTime = 0,
      long StrategyMobility = 0,
      long ActionCount = 0,
      long StrategySightRange = 0,
      long DamageRatio = 0,
      long DamagedRatio = 0,
      long DamageRatio2Increase = 0,
      long DamageRatio2Decrease = 0,
      long DamagedRatio2Increase = 0,
      long DamagedRatio2Decrease = 0,
      long ExDamagedRatioIncrease = 0,
      long ExDamagedRatioDecrease = 0,
      SCHALE.Common.FlatData.TerrainAdaptationStat StreetBattleAdaptation = SCHALE.Common.FlatData.TerrainAdaptationStat.D,
      SCHALE.Common.FlatData.TerrainAdaptationStat OutdoorBattleAdaptation = SCHALE.Common.FlatData.TerrainAdaptationStat.D,
      SCHALE.Common.FlatData.TerrainAdaptationStat IndoorBattleAdaptation = SCHALE.Common.FlatData.TerrainAdaptationStat.D,
      long RegenCost = 0) {
    builder.StartTable(66);
    CharacterStatExcel.AddRegenCost(builder, RegenCost);
    CharacterStatExcel.AddExDamagedRatioDecrease(builder, ExDamagedRatioDecrease);
    CharacterStatExcel.AddExDamagedRatioIncrease(builder, ExDamagedRatioIncrease);
    CharacterStatExcel.AddDamagedRatio2Decrease(builder, DamagedRatio2Decrease);
    CharacterStatExcel.AddDamagedRatio2Increase(builder, DamagedRatio2Increase);
    CharacterStatExcel.AddDamageRatio2Decrease(builder, DamageRatio2Decrease);
    CharacterStatExcel.AddDamageRatio2Increase(builder, DamageRatio2Increase);
    CharacterStatExcel.AddDamagedRatio(builder, DamagedRatio);
    CharacterStatExcel.AddDamageRatio(builder, DamageRatio);
    CharacterStatExcel.AddStrategySightRange(builder, StrategySightRange);
    CharacterStatExcel.AddActionCount(builder, ActionCount);
    CharacterStatExcel.AddStrategyMobility(builder, StrategyMobility);
    CharacterStatExcel.AddActiveGauge(builder, ActiveGauge);
    CharacterStatExcel.AddSightPoint(builder, SightPoint);
    CharacterStatExcel.AddMoveSpeed(builder, MoveSpeed);
    CharacterStatExcel.AddInitialRangeRate(builder, InitialRangeRate);
    CharacterStatExcel.AddRange(builder, Range);
    CharacterStatExcel.AddNormalAttackSpeed(builder, NormalAttackSpeed);
    CharacterStatExcel.AddIgnoreDelayCount(builder, IgnoreDelayCount);
    CharacterStatExcel.AddAmmoCost(builder, AmmoCost);
    CharacterStatExcel.AddAmmoCount(builder, AmmoCount);
    CharacterStatExcel.AddExtendCrowdControlDuration(builder, ExtendCrowdControlDuration);
    CharacterStatExcel.AddExtendDebuffDuration(builder, ExtendDebuffDuration);
    CharacterStatExcel.AddExtendBuffDuration(builder, ExtendBuffDuration);
    CharacterStatExcel.AddEnhanceNormalArmorRate(builder, EnhanceNormalArmorRate);
    CharacterStatExcel.AddEnhanceStructureRate(builder, EnhanceStructureRate);
    CharacterStatExcel.AddEnhanceElasticArmorRate(builder, EnhanceElasticArmorRate);
    CharacterStatExcel.AddEnhanceUnarmedRate(builder, EnhanceUnarmedRate);
    CharacterStatExcel.AddEnhanceHeavyArmorRate(builder, EnhanceHeavyArmorRate);
    CharacterStatExcel.AddEnhanceLightArmorRate(builder, EnhanceLightArmorRate);
    CharacterStatExcel.AddEnhanceNormalRate(builder, EnhanceNormalRate);
    CharacterStatExcel.AddEnhanceSiegeRate(builder, EnhanceSiegeRate);
    CharacterStatExcel.AddEnhanceSonicRate(builder, EnhanceSonicRate);
    CharacterStatExcel.AddEnhanceMysticRate(builder, EnhanceMysticRate);
    CharacterStatExcel.AddEnhancePierceRate(builder, EnhancePierceRate);
    CharacterStatExcel.AddEnhanceExplosionRate(builder, EnhanceExplosionRate);
    CharacterStatExcel.AddDefensePenetrationResist100(builder, DefensePenetrationResist100);
    CharacterStatExcel.AddDefensePenetrationResist1(builder, DefensePenetrationResist1);
    CharacterStatExcel.AddDefensePenetration100(builder, DefensePenetration100);
    CharacterStatExcel.AddDefensePenetration1(builder, DefensePenetration1);
    CharacterStatExcel.AddOppressionResist(builder, OppressionResist);
    CharacterStatExcel.AddOppressionPower(builder, OppressionPower);
    CharacterStatExcel.AddHealEffectivenessRate(builder, HealEffectivenessRate);
    CharacterStatExcel.AddBlockRate(builder, BlockRate);
    CharacterStatExcel.AddCriticalDamageResistRate(builder, CriticalDamageResistRate);
    CharacterStatExcel.AddCriticalDamageRate(builder, CriticalDamageRate);
    CharacterStatExcel.AddCriticalResistPoint(builder, CriticalResistPoint);
    CharacterStatExcel.AddCriticalPoint(builder, CriticalPoint);
    CharacterStatExcel.AddAccuracyPoint(builder, AccuracyPoint);
    CharacterStatExcel.AddDodgePoint(builder, DodgePoint);
    CharacterStatExcel.AddHealPower100(builder, HealPower100);
    CharacterStatExcel.AddHealPower1(builder, HealPower1);
    CharacterStatExcel.AddDefensePower100(builder, DefensePower100);
    CharacterStatExcel.AddDefensePower1(builder, DefensePower1);
    CharacterStatExcel.AddMaxHP100(builder, MaxHP100);
    CharacterStatExcel.AddMaxHP1(builder, MaxHP1);
    CharacterStatExcel.AddAttackPower100(builder, AttackPower100);
    CharacterStatExcel.AddAttackPower1(builder, AttackPower1);
    CharacterStatExcel.AddStabilityPoint(builder, StabilityPoint);
    CharacterStatExcel.AddStabilityRate(builder, StabilityRate);
    CharacterStatExcel.AddCharacterId(builder, CharacterId);
    CharacterStatExcel.AddIndoorBattleAdaptation(builder, IndoorBattleAdaptation);
    CharacterStatExcel.AddOutdoorBattleAdaptation(builder, OutdoorBattleAdaptation);
    CharacterStatExcel.AddStreetBattleAdaptation(builder, StreetBattleAdaptation);
    CharacterStatExcel.AddGroggyTime(builder, GroggyTime);
    CharacterStatExcel.AddGroggyGauge(builder, GroggyGauge);
    return CharacterStatExcel.EndCharacterStatExcel(builder);
  }

  public static void StartCharacterStatExcel(FlatBufferBuilder builder) { builder.StartTable(66); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(0, characterId, 0); }
  public static void AddStabilityRate(FlatBufferBuilder builder, long stabilityRate) { builder.AddLong(1, stabilityRate, 0); }
  public static void AddStabilityPoint(FlatBufferBuilder builder, long stabilityPoint) { builder.AddLong(2, stabilityPoint, 0); }
  public static void AddAttackPower1(FlatBufferBuilder builder, long attackPower1) { builder.AddLong(3, attackPower1, 0); }
  public static void AddAttackPower100(FlatBufferBuilder builder, long attackPower100) { builder.AddLong(4, attackPower100, 0); }
  public static void AddMaxHP1(FlatBufferBuilder builder, long maxHP1) { builder.AddLong(5, maxHP1, 0); }
  public static void AddMaxHP100(FlatBufferBuilder builder, long maxHP100) { builder.AddLong(6, maxHP100, 0); }
  public static void AddDefensePower1(FlatBufferBuilder builder, long defensePower1) { builder.AddLong(7, defensePower1, 0); }
  public static void AddDefensePower100(FlatBufferBuilder builder, long defensePower100) { builder.AddLong(8, defensePower100, 0); }
  public static void AddHealPower1(FlatBufferBuilder builder, long healPower1) { builder.AddLong(9, healPower1, 0); }
  public static void AddHealPower100(FlatBufferBuilder builder, long healPower100) { builder.AddLong(10, healPower100, 0); }
  public static void AddDodgePoint(FlatBufferBuilder builder, long dodgePoint) { builder.AddLong(11, dodgePoint, 0); }
  public static void AddAccuracyPoint(FlatBufferBuilder builder, long accuracyPoint) { builder.AddLong(12, accuracyPoint, 0); }
  public static void AddCriticalPoint(FlatBufferBuilder builder, long criticalPoint) { builder.AddLong(13, criticalPoint, 0); }
  public static void AddCriticalResistPoint(FlatBufferBuilder builder, long criticalResistPoint) { builder.AddLong(14, criticalResistPoint, 0); }
  public static void AddCriticalDamageRate(FlatBufferBuilder builder, long criticalDamageRate) { builder.AddLong(15, criticalDamageRate, 0); }
  public static void AddCriticalDamageResistRate(FlatBufferBuilder builder, long criticalDamageResistRate) { builder.AddLong(16, criticalDamageResistRate, 0); }
  public static void AddBlockRate(FlatBufferBuilder builder, long blockRate) { builder.AddLong(17, blockRate, 0); }
  public static void AddHealEffectivenessRate(FlatBufferBuilder builder, long healEffectivenessRate) { builder.AddLong(18, healEffectivenessRate, 0); }
  public static void AddOppressionPower(FlatBufferBuilder builder, long oppressionPower) { builder.AddLong(19, oppressionPower, 0); }
  public static void AddOppressionResist(FlatBufferBuilder builder, long oppressionResist) { builder.AddLong(20, oppressionResist, 0); }
  public static void AddDefensePenetration1(FlatBufferBuilder builder, long defensePenetration1) { builder.AddLong(21, defensePenetration1, 0); }
  public static void AddDefensePenetration100(FlatBufferBuilder builder, long defensePenetration100) { builder.AddLong(22, defensePenetration100, 0); }
  public static void AddDefensePenetrationResist1(FlatBufferBuilder builder, long defensePenetrationResist1) { builder.AddLong(23, defensePenetrationResist1, 0); }
  public static void AddDefensePenetrationResist100(FlatBufferBuilder builder, long defensePenetrationResist100) { builder.AddLong(24, defensePenetrationResist100, 0); }
  public static void AddEnhanceExplosionRate(FlatBufferBuilder builder, long enhanceExplosionRate) { builder.AddLong(25, enhanceExplosionRate, 0); }
  public static void AddEnhancePierceRate(FlatBufferBuilder builder, long enhancePierceRate) { builder.AddLong(26, enhancePierceRate, 0); }
  public static void AddEnhanceMysticRate(FlatBufferBuilder builder, long enhanceMysticRate) { builder.AddLong(27, enhanceMysticRate, 0); }
  public static void AddEnhanceSonicRate(FlatBufferBuilder builder, long enhanceSonicRate) { builder.AddLong(28, enhanceSonicRate, 0); }
  public static void AddEnhanceSiegeRate(FlatBufferBuilder builder, long enhanceSiegeRate) { builder.AddLong(29, enhanceSiegeRate, 0); }
  public static void AddEnhanceNormalRate(FlatBufferBuilder builder, long enhanceNormalRate) { builder.AddLong(30, enhanceNormalRate, 0); }
  public static void AddEnhanceLightArmorRate(FlatBufferBuilder builder, long enhanceLightArmorRate) { builder.AddLong(31, enhanceLightArmorRate, 0); }
  public static void AddEnhanceHeavyArmorRate(FlatBufferBuilder builder, long enhanceHeavyArmorRate) { builder.AddLong(32, enhanceHeavyArmorRate, 0); }
  public static void AddEnhanceUnarmedRate(FlatBufferBuilder builder, long enhanceUnarmedRate) { builder.AddLong(33, enhanceUnarmedRate, 0); }
  public static void AddEnhanceElasticArmorRate(FlatBufferBuilder builder, long enhanceElasticArmorRate) { builder.AddLong(34, enhanceElasticArmorRate, 0); }
  public static void AddEnhanceStructureRate(FlatBufferBuilder builder, long enhanceStructureRate) { builder.AddLong(35, enhanceStructureRate, 0); }
  public static void AddEnhanceNormalArmorRate(FlatBufferBuilder builder, long enhanceNormalArmorRate) { builder.AddLong(36, enhanceNormalArmorRate, 0); }
  public static void AddExtendBuffDuration(FlatBufferBuilder builder, long extendBuffDuration) { builder.AddLong(37, extendBuffDuration, 0); }
  public static void AddExtendDebuffDuration(FlatBufferBuilder builder, long extendDebuffDuration) { builder.AddLong(38, extendDebuffDuration, 0); }
  public static void AddExtendCrowdControlDuration(FlatBufferBuilder builder, long extendCrowdControlDuration) { builder.AddLong(39, extendCrowdControlDuration, 0); }
  public static void AddAmmoCount(FlatBufferBuilder builder, long ammoCount) { builder.AddLong(40, ammoCount, 0); }
  public static void AddAmmoCost(FlatBufferBuilder builder, long ammoCost) { builder.AddLong(41, ammoCost, 0); }
  public static void AddIgnoreDelayCount(FlatBufferBuilder builder, long ignoreDelayCount) { builder.AddLong(42, ignoreDelayCount, 0); }
  public static void AddNormalAttackSpeed(FlatBufferBuilder builder, long normalAttackSpeed) { builder.AddLong(43, normalAttackSpeed, 0); }
  public static void AddRange(FlatBufferBuilder builder, long range) { builder.AddLong(44, range, 0); }
  public static void AddInitialRangeRate(FlatBufferBuilder builder, long initialRangeRate) { builder.AddLong(45, initialRangeRate, 0); }
  public static void AddMoveSpeed(FlatBufferBuilder builder, long moveSpeed) { builder.AddLong(46, moveSpeed, 0); }
  public static void AddSightPoint(FlatBufferBuilder builder, long sightPoint) { builder.AddLong(47, sightPoint, 0); }
  public static void AddActiveGauge(FlatBufferBuilder builder, long activeGauge) { builder.AddLong(48, activeGauge, 0); }
  public static void AddGroggyGauge(FlatBufferBuilder builder, int groggyGauge) { builder.AddInt(49, groggyGauge, 0); }
  public static void AddGroggyTime(FlatBufferBuilder builder, int groggyTime) { builder.AddInt(50, groggyTime, 0); }
  public static void AddStrategyMobility(FlatBufferBuilder builder, long strategyMobility) { builder.AddLong(51, strategyMobility, 0); }
  public static void AddActionCount(FlatBufferBuilder builder, long actionCount) { builder.AddLong(52, actionCount, 0); }
  public static void AddStrategySightRange(FlatBufferBuilder builder, long strategySightRange) { builder.AddLong(53, strategySightRange, 0); }
  public static void AddDamageRatio(FlatBufferBuilder builder, long damageRatio) { builder.AddLong(54, damageRatio, 0); }
  public static void AddDamagedRatio(FlatBufferBuilder builder, long damagedRatio) { builder.AddLong(55, damagedRatio, 0); }
  public static void AddDamageRatio2Increase(FlatBufferBuilder builder, long damageRatio2Increase) { builder.AddLong(56, damageRatio2Increase, 0); }
  public static void AddDamageRatio2Decrease(FlatBufferBuilder builder, long damageRatio2Decrease) { builder.AddLong(57, damageRatio2Decrease, 0); }
  public static void AddDamagedRatio2Increase(FlatBufferBuilder builder, long damagedRatio2Increase) { builder.AddLong(58, damagedRatio2Increase, 0); }
  public static void AddDamagedRatio2Decrease(FlatBufferBuilder builder, long damagedRatio2Decrease) { builder.AddLong(59, damagedRatio2Decrease, 0); }
  public static void AddExDamagedRatioIncrease(FlatBufferBuilder builder, long exDamagedRatioIncrease) { builder.AddLong(60, exDamagedRatioIncrease, 0); }
  public static void AddExDamagedRatioDecrease(FlatBufferBuilder builder, long exDamagedRatioDecrease) { builder.AddLong(61, exDamagedRatioDecrease, 0); }
  public static void AddStreetBattleAdaptation(FlatBufferBuilder builder, SCHALE.Common.FlatData.TerrainAdaptationStat streetBattleAdaptation) { builder.AddInt(62, (int)streetBattleAdaptation, 0); }
  public static void AddOutdoorBattleAdaptation(FlatBufferBuilder builder, SCHALE.Common.FlatData.TerrainAdaptationStat outdoorBattleAdaptation) { builder.AddInt(63, (int)outdoorBattleAdaptation, 0); }
  public static void AddIndoorBattleAdaptation(FlatBufferBuilder builder, SCHALE.Common.FlatData.TerrainAdaptationStat indoorBattleAdaptation) { builder.AddInt(64, (int)indoorBattleAdaptation, 0); }
  public static void AddRegenCost(FlatBufferBuilder builder, long regenCost) { builder.AddLong(65, regenCost, 0); }
  public static Offset<SCHALE.Common.FlatData.CharacterStatExcel> EndCharacterStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterStatExcel>(o);
  }
}


static public class CharacterStatExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*StabilityRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*StabilityPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*AttackPower1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*AttackPower100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*MaxHP1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*MaxHP100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*DefensePower1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*DefensePower100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*HealPower1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*HealPower100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*DodgePoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*AccuracyPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*CriticalPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*CriticalResistPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*CriticalDamageRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*CriticalDamageResistRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*BlockRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*HealEffectivenessRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 42 /*OppressionPower*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*OppressionResist*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 46 /*DefensePenetration1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 48 /*DefensePenetration100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*DefensePenetrationResist1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 52 /*DefensePenetrationResist100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 54 /*EnhanceExplosionRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 56 /*EnhancePierceRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*EnhanceMysticRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 60 /*EnhanceSonicRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 62 /*EnhanceSiegeRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 64 /*EnhanceNormalRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 66 /*EnhanceLightArmorRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 68 /*EnhanceHeavyArmorRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 70 /*EnhanceUnarmedRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 72 /*EnhanceElasticArmorRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 74 /*EnhanceStructureRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 76 /*EnhanceNormalArmorRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 78 /*ExtendBuffDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 80 /*ExtendDebuffDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 82 /*ExtendCrowdControlDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 84 /*AmmoCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 86 /*AmmoCost*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 88 /*IgnoreDelayCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 90 /*NormalAttackSpeed*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 92 /*Range*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 94 /*InitialRangeRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 96 /*MoveSpeed*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 98 /*SightPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 100 /*ActiveGauge*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 102 /*GroggyGauge*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 104 /*GroggyTime*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 106 /*StrategyMobility*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 108 /*ActionCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 110 /*StrategySightRange*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 112 /*DamageRatio*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 114 /*DamagedRatio*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 116 /*DamageRatio2Increase*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 118 /*DamageRatio2Decrease*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 120 /*DamagedRatio2Increase*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 122 /*DamagedRatio2Decrease*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 124 /*ExDamagedRatioIncrease*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 126 /*ExDamagedRatioDecrease*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 128 /*StreetBattleAdaptation*/, 4 /*SCHALE.Common.FlatData.TerrainAdaptationStat*/, 4, false)
      && verifier.VerifyField(tablePos, 130 /*OutdoorBattleAdaptation*/, 4 /*SCHALE.Common.FlatData.TerrainAdaptationStat*/, 4, false)
      && verifier.VerifyField(tablePos, 132 /*IndoorBattleAdaptation*/, 4 /*SCHALE.Common.FlatData.TerrainAdaptationStat*/, 4, false)
      && verifier.VerifyField(tablePos, 134 /*RegenCost*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
