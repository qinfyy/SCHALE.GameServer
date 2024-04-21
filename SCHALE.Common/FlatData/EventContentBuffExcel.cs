// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentBuffExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentBuffExcel GetRootAsEventContentBuffExcel(ByteBuffer _bb) { return GetRootAsEventContentBuffExcel(_bb, new EventContentBuffExcel()); }
  public static EventContentBuffExcel GetRootAsEventContentBuffExcel(ByteBuffer _bb, EventContentBuffExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentBuffExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentBuffId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsBuff { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public SCHALE.Common.FlatData.Tag CharacterTag { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.Tag.A; } }
  public SCHALE.Common.FlatData.EventContentBuffFindRule EnumType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.EventContentBuffFindRule)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventContentBuffFindRule.None; } }
  public string EnumTypeValue(int j) { int o = __p.__offset(12); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int EnumTypeValueLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string SkillGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillGroupIdBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSkillGroupIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSkillGroupIdArray() { return __p.__vector_as_array<byte>(14); }
  public string IconPath { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(16); }
  public string SpriteName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpriteNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetSpriteNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetSpriteNameArray() { return __p.__vector_as_array<byte>(18); }
  public string BuffDescriptionLocalizeCodeId { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffDescriptionLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetBuffDescriptionLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetBuffDescriptionLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(20); }

  public static Offset<SCHALE.Common.FlatData.EventContentBuffExcel> CreateEventContentBuffExcel(FlatBufferBuilder builder,
      long EventContentBuffId = 0,
      bool IsBuff = false,
      SCHALE.Common.FlatData.Tag CharacterTag = SCHALE.Common.FlatData.Tag.A,
      SCHALE.Common.FlatData.EventContentBuffFindRule EnumType = SCHALE.Common.FlatData.EventContentBuffFindRule.None,
      VectorOffset EnumTypeValueOffset = default(VectorOffset),
      StringOffset SkillGroupIdOffset = default(StringOffset),
      StringOffset IconPathOffset = default(StringOffset),
      StringOffset SpriteNameOffset = default(StringOffset),
      StringOffset BuffDescriptionLocalizeCodeIdOffset = default(StringOffset)) {
    builder.StartTable(9);
    EventContentBuffExcel.AddEventContentBuffId(builder, EventContentBuffId);
    EventContentBuffExcel.AddBuffDescriptionLocalizeCodeId(builder, BuffDescriptionLocalizeCodeIdOffset);
    EventContentBuffExcel.AddSpriteName(builder, SpriteNameOffset);
    EventContentBuffExcel.AddIconPath(builder, IconPathOffset);
    EventContentBuffExcel.AddSkillGroupId(builder, SkillGroupIdOffset);
    EventContentBuffExcel.AddEnumTypeValue(builder, EnumTypeValueOffset);
    EventContentBuffExcel.AddEnumType(builder, EnumType);
    EventContentBuffExcel.AddCharacterTag(builder, CharacterTag);
    EventContentBuffExcel.AddIsBuff(builder, IsBuff);
    return EventContentBuffExcel.EndEventContentBuffExcel(builder);
  }

  public static void StartEventContentBuffExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddEventContentBuffId(FlatBufferBuilder builder, long eventContentBuffId) { builder.AddLong(0, eventContentBuffId, 0); }
  public static void AddIsBuff(FlatBufferBuilder builder, bool isBuff) { builder.AddBool(1, isBuff, false); }
  public static void AddCharacterTag(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag characterTag) { builder.AddInt(2, (int)characterTag, 0); }
  public static void AddEnumType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventContentBuffFindRule enumType) { builder.AddInt(3, (int)enumType, 0); }
  public static void AddEnumTypeValue(FlatBufferBuilder builder, VectorOffset enumTypeValueOffset) { builder.AddOffset(4, enumTypeValueOffset.Value, 0); }
  public static VectorOffset CreateEnumTypeValueVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateEnumTypeValueVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnumTypeValueVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnumTypeValueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnumTypeValueVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillGroupId(FlatBufferBuilder builder, StringOffset skillGroupIdOffset) { builder.AddOffset(5, skillGroupIdOffset.Value, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(6, iconPathOffset.Value, 0); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset spriteNameOffset) { builder.AddOffset(7, spriteNameOffset.Value, 0); }
  public static void AddBuffDescriptionLocalizeCodeId(FlatBufferBuilder builder, StringOffset buffDescriptionLocalizeCodeIdOffset) { builder.AddOffset(8, buffDescriptionLocalizeCodeIdOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.EventContentBuffExcel> EndEventContentBuffExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentBuffExcel>(o);
  }
}


static public class EventContentBuffExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentBuffId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*IsBuff*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*CharacterTag*/, 4 /*SCHALE.Common.FlatData.Tag*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*EnumType*/, 4 /*SCHALE.Common.FlatData.EventContentBuffFindRule*/, 4, false)
      && verifier.VerifyVectorOfStrings(tablePos, 12 /*EnumTypeValue*/, false)
      && verifier.VerifyString(tablePos, 14 /*SkillGroupId*/, false)
      && verifier.VerifyString(tablePos, 16 /*IconPath*/, false)
      && verifier.VerifyString(tablePos, 18 /*SpriteName*/, false)
      && verifier.VerifyString(tablePos, 20 /*BuffDescriptionLocalizeCodeId*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
