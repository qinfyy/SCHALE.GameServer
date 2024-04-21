// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ContentsScenarioExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ContentsScenarioExcel GetRootAsContentsScenarioExcel(ByteBuffer _bb) { return GetRootAsContentsScenarioExcel(_bb, new ContentsScenarioExcel()); }
  public static ContentsScenarioExcel GetRootAsContentsScenarioExcel(ByteBuffer _bb, ContentsScenarioExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ContentsScenarioExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public int DisplayOrder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public SCHALE.Common.FlatData.ScenarioContentType ScenarioContentType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.ScenarioContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioContentType.Prologue; } }
  public long ScenarioGroupId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ScenarioGroupIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetScenarioGroupIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetScenarioGroupIdArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<SCHALE.Common.FlatData.ContentsScenarioExcel> CreateContentsScenarioExcel(FlatBufferBuilder builder,
      uint Id = 0,
      uint LocalizeId = 0,
      int DisplayOrder = 0,
      SCHALE.Common.FlatData.ScenarioContentType ScenarioContentType = SCHALE.Common.FlatData.ScenarioContentType.Prologue,
      VectorOffset ScenarioGroupIdOffset = default(VectorOffset)) {
    builder.StartTable(5);
    ContentsScenarioExcel.AddScenarioGroupId(builder, ScenarioGroupIdOffset);
    ContentsScenarioExcel.AddScenarioContentType(builder, ScenarioContentType);
    ContentsScenarioExcel.AddDisplayOrder(builder, DisplayOrder);
    ContentsScenarioExcel.AddLocalizeId(builder, LocalizeId);
    ContentsScenarioExcel.AddId(builder, Id);
    return ContentsScenarioExcel.EndContentsScenarioExcel(builder);
  }

  public static void StartContentsScenarioExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, uint id) { builder.AddUint(0, id, 0); }
  public static void AddLocalizeId(FlatBufferBuilder builder, uint localizeId) { builder.AddUint(1, localizeId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, int displayOrder) { builder.AddInt(2, displayOrder, 0); }
  public static void AddScenarioContentType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioContentType scenarioContentType) { builder.AddInt(3, (int)scenarioContentType, 0); }
  public static void AddScenarioGroupId(FlatBufferBuilder builder, VectorOffset scenarioGroupIdOffset) { builder.AddOffset(4, scenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.ContentsScenarioExcel> EndContentsScenarioExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ContentsScenarioExcel>(o);
  }
}


static public class ContentsScenarioExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DisplayOrder*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ScenarioContentType*/, 4 /*SCHALE.Common.FlatData.ScenarioContentType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
