// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGEncounterRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGEncounterRewardExcel(_bb, new MinigameTBGEncounterRewardExcel()); }
  public static MinigameTBGEncounterRewardExcel GetRootAsMinigameTBGEncounterRewardExcel(ByteBuffer _bb, MinigameTBGEncounterRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGEncounterRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.TBGOptionSuccessType TBGOptionSuccessType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.TBGOptionSuccessType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.TBGOptionSuccessType.None; } }
  public long Paremeter { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ParcelType { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Amount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Prob { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.MinigameTBGEncounterRewardExcel> CreateMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      long UniqueId = 0,
      SCHALE.Common.FlatData.TBGOptionSuccessType TBGOptionSuccessType = SCHALE.Common.FlatData.TBGOptionSuccessType.None,
      long Paremeter = 0,
      SCHALE.Common.FlatData.ParcelType ParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long ParcelId = 0,
      long Amount = 0,
      int Prob = 0) {
    builder.StartTable(8);
    MinigameTBGEncounterRewardExcel.AddAmount(builder, Amount);
    MinigameTBGEncounterRewardExcel.AddParcelId(builder, ParcelId);
    MinigameTBGEncounterRewardExcel.AddParemeter(builder, Paremeter);
    MinigameTBGEncounterRewardExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGEncounterRewardExcel.AddGroupId(builder, GroupId);
    MinigameTBGEncounterRewardExcel.AddProb(builder, Prob);
    MinigameTBGEncounterRewardExcel.AddParcelType(builder, ParcelType);
    MinigameTBGEncounterRewardExcel.AddTBGOptionSuccessType(builder, TBGOptionSuccessType);
    return MinigameTBGEncounterRewardExcel.EndMinigameTBGEncounterRewardExcel(builder);
  }

  public static void StartMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(0, groupId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(1, uniqueId, 0); }
  public static void AddTBGOptionSuccessType(FlatBufferBuilder builder, SCHALE.Common.FlatData.TBGOptionSuccessType tBGOptionSuccessType) { builder.AddInt(2, (int)tBGOptionSuccessType, 0); }
  public static void AddParemeter(FlatBufferBuilder builder, long paremeter) { builder.AddLong(3, paremeter, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType parcelType) { builder.AddInt(4, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long parcelId) { builder.AddLong(5, parcelId, 0); }
  public static void AddAmount(FlatBufferBuilder builder, long amount) { builder.AddLong(6, amount, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(7, prob, 0); }
  public static Offset<SCHALE.Common.FlatData.MinigameTBGEncounterRewardExcel> EndMinigameTBGEncounterRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MinigameTBGEncounterRewardExcel>(o);
  }
}


static public class MinigameTBGEncounterRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*TBGOptionSuccessType*/, 4 /*SCHALE.Common.FlatData.TBGOptionSuccessType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Paremeter*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*Amount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
