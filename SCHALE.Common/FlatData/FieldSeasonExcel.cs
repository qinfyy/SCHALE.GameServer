// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldSeasonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldSeasonExcel GetRootAsFieldSeasonExcel(ByteBuffer _bb) { return GetRootAsFieldSeasonExcel(_bb, new FieldSeasonExcel()); }
  public static FieldSeasonExcel GetRootAsFieldSeasonExcel(ByteBuffer _bb, FieldSeasonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldSeasonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EntryDateId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long InstantEntryDateId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StartDate { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(12); }
  public string EndDate { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(14); }
  public long LobbyBGMChangeStageId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string CharacterIconPath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCharacterIconPathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetCharacterIconPathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetCharacterIconPathArray() { return __p.__vector_as_array<byte>(18); }
  public string MasteryImagePath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMasteryImagePathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetMasteryImagePathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetMasteryImagePathArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<SCHALE.Common.FlatData.FieldSeasonExcel> CreateFieldSeasonExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long EventContentId = 0,
      long EntryDateId = 0,
      long InstantEntryDateId = 0,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long LobbyBGMChangeStageId = 0,
      StringOffset CharacterIconPathOffset = default(StringOffset),
      StringOffset MasteryImagePathOffset = default(StringOffset)) {
    builder.StartTable(9);
    FieldSeasonExcel.AddLobbyBGMChangeStageId(builder, LobbyBGMChangeStageId);
    FieldSeasonExcel.AddInstantEntryDateId(builder, InstantEntryDateId);
    FieldSeasonExcel.AddEntryDateId(builder, EntryDateId);
    FieldSeasonExcel.AddEventContentId(builder, EventContentId);
    FieldSeasonExcel.AddUniqueId(builder, UniqueId);
    FieldSeasonExcel.AddMasteryImagePath(builder, MasteryImagePathOffset);
    FieldSeasonExcel.AddCharacterIconPath(builder, CharacterIconPathOffset);
    FieldSeasonExcel.AddEndDate(builder, EndDateOffset);
    FieldSeasonExcel.AddStartDate(builder, StartDateOffset);
    return FieldSeasonExcel.EndFieldSeasonExcel(builder);
  }

  public static void StartFieldSeasonExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddEntryDateId(FlatBufferBuilder builder, long entryDateId) { builder.AddLong(2, entryDateId, 0); }
  public static void AddInstantEntryDateId(FlatBufferBuilder builder, long instantEntryDateId) { builder.AddLong(3, instantEntryDateId, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset startDateOffset) { builder.AddOffset(4, startDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset endDateOffset) { builder.AddOffset(5, endDateOffset.Value, 0); }
  public static void AddLobbyBGMChangeStageId(FlatBufferBuilder builder, long lobbyBGMChangeStageId) { builder.AddLong(6, lobbyBGMChangeStageId, 0); }
  public static void AddCharacterIconPath(FlatBufferBuilder builder, StringOffset characterIconPathOffset) { builder.AddOffset(7, characterIconPathOffset.Value, 0); }
  public static void AddMasteryImagePath(FlatBufferBuilder builder, StringOffset masteryImagePathOffset) { builder.AddOffset(8, masteryImagePathOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.FieldSeasonExcel> EndFieldSeasonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FieldSeasonExcel>(o);
  }
}


static public class FieldSeasonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*EntryDateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*InstantEntryDateId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*StartDate*/, false)
      && verifier.VerifyString(tablePos, 14 /*EndDate*/, false)
      && verifier.VerifyField(tablePos, 16 /*LobbyBGMChangeStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 18 /*CharacterIconPath*/, false)
      && verifier.VerifyString(tablePos, 20 /*MasteryImagePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
