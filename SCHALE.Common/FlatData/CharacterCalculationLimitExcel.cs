// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterCalculationLimitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterCalculationLimitExcel GetRootAsCharacterCalculationLimitExcel(ByteBuffer _bb) { return GetRootAsCharacterCalculationLimitExcel(_bb, new CharacterCalculationLimitExcel()); }
  public static CharacterCalculationLimitExcel GetRootAsCharacterCalculationLimitExcel(ByteBuffer _bb, CharacterCalculationLimitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterCalculationLimitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TacticEntityType.None; } }
  public SCHALE.Common.FlatData.BattleCalculationStat CalculationValue { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.BattleCalculationStat)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.BattleCalculationStat.FinalDamage; } }
  public long MinValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.CharacterCalculationLimitExcel> CreateCharacterCalculationLimitExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.TacticEntityType TacticEntityType = SCHALE.Common.FlatData.TacticEntityType.None,
      SCHALE.Common.FlatData.BattleCalculationStat CalculationValue = SCHALE.Common.FlatData.BattleCalculationStat.FinalDamage,
      long MinValue = 0,
      long MaxValue = 0) {
    builder.StartTable(5);
    CharacterCalculationLimitExcel.AddMaxValue(builder, MaxValue);
    CharacterCalculationLimitExcel.AddMinValue(builder, MinValue);
    CharacterCalculationLimitExcel.AddId(builder, Id);
    CharacterCalculationLimitExcel.AddCalculationValue(builder, CalculationValue);
    CharacterCalculationLimitExcel.AddTacticEntityType(builder, TacticEntityType);
    return CharacterCalculationLimitExcel.EndCharacterCalculationLimitExcel(builder);
  }

  public static void StartCharacterCalculationLimitExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, SCHALE.Common.FlatData.TacticEntityType tacticEntityType) { builder.AddInt(1, (int)tacticEntityType, 0); }
  public static void AddCalculationValue(FlatBufferBuilder builder, SCHALE.Common.FlatData.BattleCalculationStat calculationValue) { builder.AddInt(2, (int)calculationValue, 0); }
  public static void AddMinValue(FlatBufferBuilder builder, long minValue) { builder.AddLong(3, minValue, 0); }
  public static void AddMaxValue(FlatBufferBuilder builder, long maxValue) { builder.AddLong(4, maxValue, 0); }
  public static Offset<SCHALE.Common.FlatData.CharacterCalculationLimitExcel> EndCharacterCalculationLimitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterCalculationLimitExcel>(o);
  }
}


static public class CharacterCalculationLimitExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*TacticEntityType*/, 4 /*SCHALE.Common.FlatData.TacticEntityType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*CalculationValue*/, 4 /*SCHALE.Common.FlatData.BattleCalculationStat*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*MinValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*MaxValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
