// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioExcel GetRootAsScenarioExcel(ByteBuffer _bb) { return GetRootAsScenarioExcel(_bb, new ScenarioExcel()); }
  public static ScenarioExcel GetRootAsScenarioExcel(ByteBuffer _bb, ScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.ScenarioBGType None(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.ScenarioBGType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ScenarioBGType)0; }
  public int NoneLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ScenarioBGType> GetNoneBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ScenarioBGType>(4, 4); }
#else
  public ArraySegment<byte>? GetNoneBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public SCHALE.Common.FlatData.ScenarioBGType[] GetNoneArray() { int o = __p.__offset(4); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ScenarioBGType[] a = new SCHALE.Common.FlatData.ScenarioBGType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ScenarioBGType)__p.bb.GetInt(p + i * 4); } return a; }
  public SCHALE.Common.FlatData.ScenarioCharacterAction Idle(int j) { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ScenarioCharacterAction)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ScenarioCharacterAction)0; }
  public int IdleLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ScenarioCharacterAction> GetIdleBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ScenarioCharacterAction>(6, 4); }
#else
  public ArraySegment<byte>? GetIdleBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public SCHALE.Common.FlatData.ScenarioCharacterAction[] GetIdleArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ScenarioCharacterAction[] a = new SCHALE.Common.FlatData.ScenarioCharacterAction[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ScenarioCharacterAction)__p.bb.GetInt(p + i * 4); } return a; }
  public SCHALE.Common.FlatData.DialogCategory Cafe { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.DialogCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.DialogCategory.Cafe; } }
  public SCHALE.Common.FlatData.DialogType Talk { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.DialogType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.DialogType.Talk; } }
  public SCHALE.Common.FlatData.StoryCondition Open { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.StoryCondition)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StoryCondition.Open; } }
  public SCHALE.Common.FlatData.EmojiEvent EnterConver { get { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.EmojiEvent)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EmojiEvent.EnterConver; } }
  public SCHALE.Common.FlatData.ScenarioZoomAnchors Center { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ScenarioZoomAnchors)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioZoomAnchors.Center; } }
  public SCHALE.Common.FlatData.ScenarioZoomType Instant { get { int o = __p.__offset(18); return o != 0 ? (SCHALE.Common.FlatData.ScenarioZoomType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioZoomType.Instant; } }
  public SCHALE.Common.FlatData.ScenarioContentType Prologue { get { int o = __p.__offset(20); return o != 0 ? (SCHALE.Common.FlatData.ScenarioContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioContentType.Prologue; } }

  public static Offset<SCHALE.Common.FlatData.ScenarioExcel> CreateScenarioExcel(FlatBufferBuilder builder,
      VectorOffset NoneOffset = default(VectorOffset),
      VectorOffset IdleOffset = default(VectorOffset),
      SCHALE.Common.FlatData.DialogCategory Cafe = SCHALE.Common.FlatData.DialogCategory.Cafe,
      SCHALE.Common.FlatData.DialogType Talk = SCHALE.Common.FlatData.DialogType.Talk,
      SCHALE.Common.FlatData.StoryCondition Open = SCHALE.Common.FlatData.StoryCondition.Open,
      SCHALE.Common.FlatData.EmojiEvent EnterConver = SCHALE.Common.FlatData.EmojiEvent.EnterConver,
      SCHALE.Common.FlatData.ScenarioZoomAnchors Center = SCHALE.Common.FlatData.ScenarioZoomAnchors.Center,
      SCHALE.Common.FlatData.ScenarioZoomType Instant = SCHALE.Common.FlatData.ScenarioZoomType.Instant,
      SCHALE.Common.FlatData.ScenarioContentType Prologue = SCHALE.Common.FlatData.ScenarioContentType.Prologue) {
    builder.StartTable(9);
    ScenarioExcel.AddPrologue(builder, Prologue);
    ScenarioExcel.AddInstant(builder, Instant);
    ScenarioExcel.AddCenter(builder, Center);
    ScenarioExcel.AddEnterConver(builder, EnterConver);
    ScenarioExcel.AddOpen(builder, Open);
    ScenarioExcel.AddTalk(builder, Talk);
    ScenarioExcel.AddCafe(builder, Cafe);
    ScenarioExcel.AddIdle(builder, IdleOffset);
    ScenarioExcel.AddNone(builder, NoneOffset);
    return ScenarioExcel.EndScenarioExcel(builder);
  }

  public static void StartScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddNone(FlatBufferBuilder builder, VectorOffset noneOffset) { builder.AddOffset(0, noneOffset.Value, 0); }
  public static VectorOffset CreateNoneVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioBGType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateNoneVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioBGType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNoneVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ScenarioBGType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNoneVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ScenarioBGType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNoneVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIdle(FlatBufferBuilder builder, VectorOffset idleOffset) { builder.AddOffset(1, idleOffset.Value, 0); }
  public static VectorOffset CreateIdleVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioCharacterAction[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateIdleVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioCharacterAction[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIdleVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ScenarioCharacterAction> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateIdleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ScenarioCharacterAction>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartIdleVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCafe(FlatBufferBuilder builder, SCHALE.Common.FlatData.DialogCategory cafe) { builder.AddInt(2, (int)cafe, 0); }
  public static void AddTalk(FlatBufferBuilder builder, SCHALE.Common.FlatData.DialogType talk) { builder.AddInt(3, (int)talk, 0); }
  public static void AddOpen(FlatBufferBuilder builder, SCHALE.Common.FlatData.StoryCondition open) { builder.AddInt(4, (int)open, 0); }
  public static void AddEnterConver(FlatBufferBuilder builder, SCHALE.Common.FlatData.EmojiEvent enterConver) { builder.AddInt(5, (int)enterConver, 0); }
  public static void AddCenter(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioZoomAnchors center) { builder.AddInt(6, (int)center, 0); }
  public static void AddInstant(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioZoomType instant) { builder.AddInt(7, (int)instant, 0); }
  public static void AddPrologue(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioContentType prologue) { builder.AddInt(8, (int)prologue, 0); }
  public static Offset<SCHALE.Common.FlatData.ScenarioExcel> EndScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ScenarioExcel>(o);
  }
}


static public class ScenarioExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfData(tablePos, 4 /*None*/, 4 /*SCHALE.Common.FlatData.ScenarioBGType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*Idle*/, 4 /*SCHALE.Common.FlatData.ScenarioCharacterAction*/, false)
      && verifier.VerifyField(tablePos, 8 /*Cafe*/, 4 /*SCHALE.Common.FlatData.DialogCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Talk*/, 4 /*SCHALE.Common.FlatData.DialogType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Open*/, 4 /*SCHALE.Common.FlatData.StoryCondition*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*EnterConver*/, 4 /*SCHALE.Common.FlatData.EmojiEvent*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Center*/, 4 /*SCHALE.Common.FlatData.ScenarioZoomAnchors*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*Instant*/, 4 /*SCHALE.Common.FlatData.ScenarioZoomType*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*Prologue*/, 4 /*SCHALE.Common.FlatData.ScenarioContentType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
