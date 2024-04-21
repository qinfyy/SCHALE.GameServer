// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MultiFloorRaidRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MultiFloorRaidRewardExcel GetRootAsMultiFloorRaidRewardExcel(ByteBuffer _bb) { return GetRootAsMultiFloorRaidRewardExcel(_bb, new MultiFloorRaidRewardExcel()); }
  public static MultiFloorRaidRewardExcel GetRootAsMultiFloorRaidRewardExcel(ByteBuffer _bb, MultiFloorRaidRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MultiFloorRaidRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long RewardGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearStageRewardProb { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ClearStageRewardParcelType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ClearStageRewardParcelUniqueID { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearStageRewardAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.MultiFloorRaidRewardExcel> CreateMultiFloorRaidRewardExcel(FlatBufferBuilder builder,
      long RewardGroupId = 0,
      long ClearStageRewardProb = 0,
      SCHALE.Common.FlatData.ParcelType ClearStageRewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long ClearStageRewardParcelUniqueID = 0,
      long ClearStageRewardAmount = 0) {
    builder.StartTable(5);
    MultiFloorRaidRewardExcel.AddClearStageRewardAmount(builder, ClearStageRewardAmount);
    MultiFloorRaidRewardExcel.AddClearStageRewardParcelUniqueID(builder, ClearStageRewardParcelUniqueID);
    MultiFloorRaidRewardExcel.AddClearStageRewardProb(builder, ClearStageRewardProb);
    MultiFloorRaidRewardExcel.AddRewardGroupId(builder, RewardGroupId);
    MultiFloorRaidRewardExcel.AddClearStageRewardParcelType(builder, ClearStageRewardParcelType);
    return MultiFloorRaidRewardExcel.EndMultiFloorRaidRewardExcel(builder);
  }

  public static void StartMultiFloorRaidRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddRewardGroupId(FlatBufferBuilder builder, long rewardGroupId) { builder.AddLong(0, rewardGroupId, 0); }
  public static void AddClearStageRewardProb(FlatBufferBuilder builder, long clearStageRewardProb) { builder.AddLong(1, clearStageRewardProb, 0); }
  public static void AddClearStageRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType clearStageRewardParcelType) { builder.AddInt(2, (int)clearStageRewardParcelType, 0); }
  public static void AddClearStageRewardParcelUniqueID(FlatBufferBuilder builder, long clearStageRewardParcelUniqueID) { builder.AddLong(3, clearStageRewardParcelUniqueID, 0); }
  public static void AddClearStageRewardAmount(FlatBufferBuilder builder, long clearStageRewardAmount) { builder.AddLong(4, clearStageRewardAmount, 0); }
  public static Offset<SCHALE.Common.FlatData.MultiFloorRaidRewardExcel> EndMultiFloorRaidRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MultiFloorRaidRewardExcel>(o);
  }
}


static public class MultiFloorRaidRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*RewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ClearStageRewardProb*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ClearStageRewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ClearStageRewardParcelUniqueID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ClearStageRewardAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
