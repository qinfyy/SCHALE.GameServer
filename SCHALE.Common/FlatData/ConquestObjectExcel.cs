// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestObjectExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestObjectExcel GetRootAsConquestObjectExcel(ByteBuffer _bb) { return GetRootAsConquestObjectExcel(_bb, new ConquestObjectExcel()); }
  public static ConquestObjectExcel GetRootAsConquestObjectExcel(ByteBuffer _bb, ConquestObjectExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestObjectExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ConquestObjectType ConquestObjectType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ConquestObjectType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ConquestObjectType.None; } }
  public uint Key { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(12); }
  public string PrefabName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(14); }
  public SCHALE.Common.FlatData.ParcelType ConquestRewardParcelType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ConquestRewardID { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ConquestRewardAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool Disposable { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int StepIndex { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StepObjectCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.ConquestObjectExcel> CreateConquestObjectExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      SCHALE.Common.FlatData.ConquestObjectType ConquestObjectType = SCHALE.Common.FlatData.ConquestObjectType.None,
      uint Key = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset PrefabNameOffset = default(StringOffset),
      SCHALE.Common.FlatData.ParcelType ConquestRewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long ConquestRewardID = 0,
      int ConquestRewardAmount = 0,
      bool Disposable = false,
      int StepIndex = 0,
      int StepObjectCount = 0) {
    builder.StartTable(12);
    ConquestObjectExcel.AddConquestRewardID(builder, ConquestRewardID);
    ConquestObjectExcel.AddEventContentId(builder, EventContentId);
    ConquestObjectExcel.AddId(builder, Id);
    ConquestObjectExcel.AddStepObjectCount(builder, StepObjectCount);
    ConquestObjectExcel.AddStepIndex(builder, StepIndex);
    ConquestObjectExcel.AddConquestRewardAmount(builder, ConquestRewardAmount);
    ConquestObjectExcel.AddConquestRewardParcelType(builder, ConquestRewardParcelType);
    ConquestObjectExcel.AddPrefabName(builder, PrefabNameOffset);
    ConquestObjectExcel.AddName(builder, NameOffset);
    ConquestObjectExcel.AddKey(builder, Key);
    ConquestObjectExcel.AddConquestObjectType(builder, ConquestObjectType);
    ConquestObjectExcel.AddDisposable(builder, Disposable);
    return ConquestObjectExcel.EndConquestObjectExcel(builder);
  }

  public static void StartConquestObjectExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddConquestObjectType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ConquestObjectType conquestObjectType) { builder.AddInt(2, (int)conquestObjectType, 0); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(3, key, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(4, nameOffset.Value, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(5, prefabNameOffset.Value, 0); }
  public static void AddConquestRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType conquestRewardParcelType) { builder.AddInt(6, (int)conquestRewardParcelType, 0); }
  public static void AddConquestRewardID(FlatBufferBuilder builder, long conquestRewardID) { builder.AddLong(7, conquestRewardID, 0); }
  public static void AddConquestRewardAmount(FlatBufferBuilder builder, int conquestRewardAmount) { builder.AddInt(8, conquestRewardAmount, 0); }
  public static void AddDisposable(FlatBufferBuilder builder, bool disposable) { builder.AddBool(9, disposable, false); }
  public static void AddStepIndex(FlatBufferBuilder builder, int stepIndex) { builder.AddInt(10, stepIndex, 0); }
  public static void AddStepObjectCount(FlatBufferBuilder builder, int stepObjectCount) { builder.AddInt(11, stepObjectCount, 0); }
  public static Offset<SCHALE.Common.FlatData.ConquestObjectExcel> EndConquestObjectExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConquestObjectExcel>(o);
  }
}


static public class ConquestObjectExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ConquestObjectType*/, 4 /*SCHALE.Common.FlatData.ConquestObjectType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*Name*/, false)
      && verifier.VerifyString(tablePos, 14 /*PrefabName*/, false)
      && verifier.VerifyField(tablePos, 16 /*ConquestRewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ConquestRewardID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*ConquestRewardAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*Disposable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 24 /*StepIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*StepObjectCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
