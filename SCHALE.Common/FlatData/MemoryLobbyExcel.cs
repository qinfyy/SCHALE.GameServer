// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MemoryLobbyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MemoryLobbyExcel GetRootAsMemoryLobbyExcel(ByteBuffer _bb) { return GetRootAsMemoryLobbyExcel(_bb, new MemoryLobbyExcel()); }
  public static MemoryLobbyExcel GetRootAsMemoryLobbyExcel(ByteBuffer _bb, MemoryLobbyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MemoryLobbyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ProductionStep ProductionStep { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ProductionStep.ToDo; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long CharacterId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PrefabName { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(12); }
  public SCHALE.Common.FlatData.MemoryLobbyCategory MemoryLobbyCategory { get { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.MemoryLobbyCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MemoryLobbyCategory.None; } }
  public string SlotTextureName { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSlotTextureNameBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetSlotTextureNameBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetSlotTextureNameArray() { return __p.__vector_as_array<byte>(16); }
  public string RewardTextureName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardTextureNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetRewardTextureNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetRewardTextureNameArray() { return __p.__vector_as_array<byte>(18); }
  public long BGMId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AudioClipJp { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipJpBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetAudioClipJpBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetAudioClipJpArray() { return __p.__vector_as_array<byte>(22); }
  public string AudioClipKr { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAudioClipKrBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetAudioClipKrBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetAudioClipKrArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<SCHALE.Common.FlatData.MemoryLobbyExcel> CreateMemoryLobbyExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.ProductionStep ProductionStep = SCHALE.Common.FlatData.ProductionStep.ToDo,
      uint LocalizeEtcId = 0,
      long CharacterId = 0,
      StringOffset PrefabNameOffset = default(StringOffset),
      SCHALE.Common.FlatData.MemoryLobbyCategory MemoryLobbyCategory = SCHALE.Common.FlatData.MemoryLobbyCategory.None,
      StringOffset SlotTextureNameOffset = default(StringOffset),
      StringOffset RewardTextureNameOffset = default(StringOffset),
      long BGMId = 0,
      StringOffset AudioClipJpOffset = default(StringOffset),
      StringOffset AudioClipKrOffset = default(StringOffset)) {
    builder.StartTable(11);
    MemoryLobbyExcel.AddBGMId(builder, BGMId);
    MemoryLobbyExcel.AddCharacterId(builder, CharacterId);
    MemoryLobbyExcel.AddId(builder, Id);
    MemoryLobbyExcel.AddAudioClipKr(builder, AudioClipKrOffset);
    MemoryLobbyExcel.AddAudioClipJp(builder, AudioClipJpOffset);
    MemoryLobbyExcel.AddRewardTextureName(builder, RewardTextureNameOffset);
    MemoryLobbyExcel.AddSlotTextureName(builder, SlotTextureNameOffset);
    MemoryLobbyExcel.AddMemoryLobbyCategory(builder, MemoryLobbyCategory);
    MemoryLobbyExcel.AddPrefabName(builder, PrefabNameOffset);
    MemoryLobbyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    MemoryLobbyExcel.AddProductionStep(builder, ProductionStep);
    return MemoryLobbyExcel.EndMemoryLobbyExcel(builder);
  }

  public static void StartMemoryLobbyExcel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, SCHALE.Common.FlatData.ProductionStep productionStep) { builder.AddInt(1, (int)productionStep, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(3, characterId, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(4, prefabNameOffset.Value, 0); }
  public static void AddMemoryLobbyCategory(FlatBufferBuilder builder, SCHALE.Common.FlatData.MemoryLobbyCategory memoryLobbyCategory) { builder.AddInt(5, (int)memoryLobbyCategory, 0); }
  public static void AddSlotTextureName(FlatBufferBuilder builder, StringOffset slotTextureNameOffset) { builder.AddOffset(6, slotTextureNameOffset.Value, 0); }
  public static void AddRewardTextureName(FlatBufferBuilder builder, StringOffset rewardTextureNameOffset) { builder.AddOffset(7, rewardTextureNameOffset.Value, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(8, bGMId, 0); }
  public static void AddAudioClipJp(FlatBufferBuilder builder, StringOffset audioClipJpOffset) { builder.AddOffset(9, audioClipJpOffset.Value, 0); }
  public static void AddAudioClipKr(FlatBufferBuilder builder, StringOffset audioClipKrOffset) { builder.AddOffset(10, audioClipKrOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.MemoryLobbyExcel> EndMemoryLobbyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MemoryLobbyExcel>(o);
  }
}


static public class MemoryLobbyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ProductionStep*/, 4 /*SCHALE.Common.FlatData.ProductionStep*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*PrefabName*/, false)
      && verifier.VerifyField(tablePos, 14 /*MemoryLobbyCategory*/, 4 /*SCHALE.Common.FlatData.MemoryLobbyCategory*/, 4, false)
      && verifier.VerifyString(tablePos, 16 /*SlotTextureName*/, false)
      && verifier.VerifyString(tablePos, 18 /*RewardTextureName*/, false)
      && verifier.VerifyField(tablePos, 20 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 22 /*AudioClipJp*/, false)
      && verifier.VerifyString(tablePos, 24 /*AudioClipKr*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
