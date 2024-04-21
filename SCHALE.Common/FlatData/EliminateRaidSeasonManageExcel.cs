// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EliminateRaidSeasonManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EliminateRaidSeasonManageExcel GetRootAsEliminateRaidSeasonManageExcel(ByteBuffer _bb) { return GetRootAsEliminateRaidSeasonManageExcel(_bb, new EliminateRaidSeasonManageExcel()); }
  public static EliminateRaidSeasonManageExcel GetRootAsEliminateRaidSeasonManageExcel(ByteBuffer _bb, EliminateRaidSeasonManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EliminateRaidSeasonManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonDisplay { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SeasonStartData { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonStartDataBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSeasonStartDataBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSeasonStartDataArray() { return __p.__vector_as_array<byte>(8); }
  public string SeasonEndData { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSeasonEndDataBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSeasonEndDataBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSeasonEndDataArray() { return __p.__vector_as_array<byte>(10); }
  public string SettlementEndDate { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSettlementEndDateBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSettlementEndDateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSettlementEndDateArray() { return __p.__vector_as_array<byte>(12); }
  public string LobbyTableBGPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyTableBGPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetLobbyTableBGPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetLobbyTableBGPathArray() { return __p.__vector_as_array<byte>(14); }
  public string LobbyScreenBGPath { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLobbyScreenBGPathBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetLobbyScreenBGPathBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetLobbyScreenBGPathArray() { return __p.__vector_as_array<byte>(16); }
  public string OpenRaidBossGroup01 { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup01Bytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup01Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetOpenRaidBossGroup01Array() { return __p.__vector_as_array<byte>(18); }
  public string OpenRaidBossGroup02 { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup02Bytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup02Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetOpenRaidBossGroup02Array() { return __p.__vector_as_array<byte>(20); }
  public string OpenRaidBossGroup03 { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenRaidBossGroup03Bytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetOpenRaidBossGroup03Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetOpenRaidBossGroup03Array() { return __p.__vector_as_array<byte>(22); }
  public long RankingRewardGroupId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxSeasonRewardGauage { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StackedSeasonRewardGauge(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StackedSeasonRewardGaugeLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetStackedSeasonRewardGaugeBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetStackedSeasonRewardGaugeArray() { return __p.__vector_as_array<long>(28); }
  public long SeasonRewardId(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardIdBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetSeasonRewardIdArray() { return __p.__vector_as_array<long>(30); }
  public long LimitedRewardIdNormal { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdHard { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdVeryhard { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdHardcore { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdExtreme { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdInsane { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LimitedRewardIdTorment { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.EliminateRaidSeasonManageExcel> CreateEliminateRaidSeasonManageExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long SeasonDisplay = 0,
      StringOffset SeasonStartDataOffset = default(StringOffset),
      StringOffset SeasonEndDataOffset = default(StringOffset),
      StringOffset SettlementEndDateOffset = default(StringOffset),
      StringOffset LobbyTableBGPathOffset = default(StringOffset),
      StringOffset LobbyScreenBGPathOffset = default(StringOffset),
      StringOffset OpenRaidBossGroup01Offset = default(StringOffset),
      StringOffset OpenRaidBossGroup02Offset = default(StringOffset),
      StringOffset OpenRaidBossGroup03Offset = default(StringOffset),
      long RankingRewardGroupId = 0,
      int MaxSeasonRewardGauage = 0,
      VectorOffset StackedSeasonRewardGaugeOffset = default(VectorOffset),
      VectorOffset SeasonRewardIdOffset = default(VectorOffset),
      long LimitedRewardIdNormal = 0,
      long LimitedRewardIdHard = 0,
      long LimitedRewardIdVeryhard = 0,
      long LimitedRewardIdHardcore = 0,
      long LimitedRewardIdExtreme = 0,
      long LimitedRewardIdInsane = 0,
      long LimitedRewardIdTorment = 0) {
    builder.StartTable(21);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdTorment(builder, LimitedRewardIdTorment);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdInsane(builder, LimitedRewardIdInsane);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdExtreme(builder, LimitedRewardIdExtreme);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdHardcore(builder, LimitedRewardIdHardcore);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdVeryhard(builder, LimitedRewardIdVeryhard);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdHard(builder, LimitedRewardIdHard);
    EliminateRaidSeasonManageExcel.AddLimitedRewardIdNormal(builder, LimitedRewardIdNormal);
    EliminateRaidSeasonManageExcel.AddRankingRewardGroupId(builder, RankingRewardGroupId);
    EliminateRaidSeasonManageExcel.AddSeasonDisplay(builder, SeasonDisplay);
    EliminateRaidSeasonManageExcel.AddSeasonId(builder, SeasonId);
    EliminateRaidSeasonManageExcel.AddSeasonRewardId(builder, SeasonRewardIdOffset);
    EliminateRaidSeasonManageExcel.AddStackedSeasonRewardGauge(builder, StackedSeasonRewardGaugeOffset);
    EliminateRaidSeasonManageExcel.AddMaxSeasonRewardGauage(builder, MaxSeasonRewardGauage);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup03(builder, OpenRaidBossGroup03Offset);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup02(builder, OpenRaidBossGroup02Offset);
    EliminateRaidSeasonManageExcel.AddOpenRaidBossGroup01(builder, OpenRaidBossGroup01Offset);
    EliminateRaidSeasonManageExcel.AddLobbyScreenBGPath(builder, LobbyScreenBGPathOffset);
    EliminateRaidSeasonManageExcel.AddLobbyTableBGPath(builder, LobbyTableBGPathOffset);
    EliminateRaidSeasonManageExcel.AddSettlementEndDate(builder, SettlementEndDateOffset);
    EliminateRaidSeasonManageExcel.AddSeasonEndData(builder, SeasonEndDataOffset);
    EliminateRaidSeasonManageExcel.AddSeasonStartData(builder, SeasonStartDataOffset);
    return EliminateRaidSeasonManageExcel.EndEliminateRaidSeasonManageExcel(builder);
  }

  public static void StartEliminateRaidSeasonManageExcel(FlatBufferBuilder builder) { builder.StartTable(21); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(0, seasonId, 0); }
  public static void AddSeasonDisplay(FlatBufferBuilder builder, long seasonDisplay) { builder.AddLong(1, seasonDisplay, 0); }
  public static void AddSeasonStartData(FlatBufferBuilder builder, StringOffset seasonStartDataOffset) { builder.AddOffset(2, seasonStartDataOffset.Value, 0); }
  public static void AddSeasonEndData(FlatBufferBuilder builder, StringOffset seasonEndDataOffset) { builder.AddOffset(3, seasonEndDataOffset.Value, 0); }
  public static void AddSettlementEndDate(FlatBufferBuilder builder, StringOffset settlementEndDateOffset) { builder.AddOffset(4, settlementEndDateOffset.Value, 0); }
  public static void AddLobbyTableBGPath(FlatBufferBuilder builder, StringOffset lobbyTableBGPathOffset) { builder.AddOffset(5, lobbyTableBGPathOffset.Value, 0); }
  public static void AddLobbyScreenBGPath(FlatBufferBuilder builder, StringOffset lobbyScreenBGPathOffset) { builder.AddOffset(6, lobbyScreenBGPathOffset.Value, 0); }
  public static void AddOpenRaidBossGroup01(FlatBufferBuilder builder, StringOffset openRaidBossGroup01Offset) { builder.AddOffset(7, openRaidBossGroup01Offset.Value, 0); }
  public static void AddOpenRaidBossGroup02(FlatBufferBuilder builder, StringOffset openRaidBossGroup02Offset) { builder.AddOffset(8, openRaidBossGroup02Offset.Value, 0); }
  public static void AddOpenRaidBossGroup03(FlatBufferBuilder builder, StringOffset openRaidBossGroup03Offset) { builder.AddOffset(9, openRaidBossGroup03Offset.Value, 0); }
  public static void AddRankingRewardGroupId(FlatBufferBuilder builder, long rankingRewardGroupId) { builder.AddLong(10, rankingRewardGroupId, 0); }
  public static void AddMaxSeasonRewardGauage(FlatBufferBuilder builder, int maxSeasonRewardGauage) { builder.AddInt(11, maxSeasonRewardGauage, 0); }
  public static void AddStackedSeasonRewardGauge(FlatBufferBuilder builder, VectorOffset stackedSeasonRewardGaugeOffset) { builder.AddOffset(12, stackedSeasonRewardGaugeOffset.Value, 0); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStackedSeasonRewardGaugeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStackedSeasonRewardGaugeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, VectorOffset seasonRewardIdOffset) { builder.AddOffset(13, seasonRewardIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddLimitedRewardIdNormal(FlatBufferBuilder builder, long limitedRewardIdNormal) { builder.AddLong(14, limitedRewardIdNormal, 0); }
  public static void AddLimitedRewardIdHard(FlatBufferBuilder builder, long limitedRewardIdHard) { builder.AddLong(15, limitedRewardIdHard, 0); }
  public static void AddLimitedRewardIdVeryhard(FlatBufferBuilder builder, long limitedRewardIdVeryhard) { builder.AddLong(16, limitedRewardIdVeryhard, 0); }
  public static void AddLimitedRewardIdHardcore(FlatBufferBuilder builder, long limitedRewardIdHardcore) { builder.AddLong(17, limitedRewardIdHardcore, 0); }
  public static void AddLimitedRewardIdExtreme(FlatBufferBuilder builder, long limitedRewardIdExtreme) { builder.AddLong(18, limitedRewardIdExtreme, 0); }
  public static void AddLimitedRewardIdInsane(FlatBufferBuilder builder, long limitedRewardIdInsane) { builder.AddLong(19, limitedRewardIdInsane, 0); }
  public static void AddLimitedRewardIdTorment(FlatBufferBuilder builder, long limitedRewardIdTorment) { builder.AddLong(20, limitedRewardIdTorment, 0); }
  public static Offset<SCHALE.Common.FlatData.EliminateRaidSeasonManageExcel> EndEliminateRaidSeasonManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EliminateRaidSeasonManageExcel>(o);
  }
}


static public class EliminateRaidSeasonManageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonDisplay*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*SeasonStartData*/, false)
      && verifier.VerifyString(tablePos, 10 /*SeasonEndData*/, false)
      && verifier.VerifyString(tablePos, 12 /*SettlementEndDate*/, false)
      && verifier.VerifyString(tablePos, 14 /*LobbyTableBGPath*/, false)
      && verifier.VerifyString(tablePos, 16 /*LobbyScreenBGPath*/, false)
      && verifier.VerifyString(tablePos, 18 /*OpenRaidBossGroup01*/, false)
      && verifier.VerifyString(tablePos, 20 /*OpenRaidBossGroup02*/, false)
      && verifier.VerifyString(tablePos, 22 /*OpenRaidBossGroup03*/, false)
      && verifier.VerifyField(tablePos, 24 /*RankingRewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*MaxSeasonRewardGauage*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*StackedSeasonRewardGauge*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*SeasonRewardId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 32 /*LimitedRewardIdNormal*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*LimitedRewardIdHard*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*LimitedRewardIdVeryhard*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*LimitedRewardIdHardcore*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*LimitedRewardIdExtreme*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 42 /*LimitedRewardIdInsane*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*LimitedRewardIdTorment*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
