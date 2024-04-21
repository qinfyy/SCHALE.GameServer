// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct BuffParticleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static BuffParticleExcel GetRootAsBuffParticleExcel(ByteBuffer _bb) { return GetRootAsBuffParticleExcel(_bb, new BuffParticleExcel()); }
  public static BuffParticleExcel GetRootAsBuffParticleExcel(ByteBuffer _bb, BuffParticleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BuffParticleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string UniqueName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUniqueNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetUniqueNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetUniqueNameArray() { return __p.__vector_as_array<byte>(6); }
  public string BuffType { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffTypeBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBuffTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBuffTypeArray() { return __p.__vector_as_array<byte>(8); }
  public string BuffName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetBuffNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetBuffNameArray() { return __p.__vector_as_array<byte>(10); }
  public string ResourcePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetResourcePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetResourcePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetResourcePathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<SCHALE.Common.FlatData.BuffParticleExcel> CreateBuffParticleExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset UniqueNameOffset = default(StringOffset),
      StringOffset BuffTypeOffset = default(StringOffset),
      StringOffset BuffNameOffset = default(StringOffset),
      StringOffset ResourcePathOffset = default(StringOffset)) {
    builder.StartTable(5);
    BuffParticleExcel.AddUniqueId(builder, UniqueId);
    BuffParticleExcel.AddResourcePath(builder, ResourcePathOffset);
    BuffParticleExcel.AddBuffName(builder, BuffNameOffset);
    BuffParticleExcel.AddBuffType(builder, BuffTypeOffset);
    BuffParticleExcel.AddUniqueName(builder, UniqueNameOffset);
    return BuffParticleExcel.EndBuffParticleExcel(builder);
  }

  public static void StartBuffParticleExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddUniqueName(FlatBufferBuilder builder, StringOffset uniqueNameOffset) { builder.AddOffset(1, uniqueNameOffset.Value, 0); }
  public static void AddBuffType(FlatBufferBuilder builder, StringOffset buffTypeOffset) { builder.AddOffset(2, buffTypeOffset.Value, 0); }
  public static void AddBuffName(FlatBufferBuilder builder, StringOffset buffNameOffset) { builder.AddOffset(3, buffNameOffset.Value, 0); }
  public static void AddResourcePath(FlatBufferBuilder builder, StringOffset resourcePathOffset) { builder.AddOffset(4, resourcePathOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.BuffParticleExcel> EndBuffParticleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.BuffParticleExcel>(o);
  }
}


static public class BuffParticleExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*UniqueName*/, false)
      && verifier.VerifyString(tablePos, 8 /*BuffType*/, false)
      && verifier.VerifyString(tablePos, 10 /*BuffName*/, false)
      && verifier.VerifyString(tablePos, 12 /*ResourcePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
