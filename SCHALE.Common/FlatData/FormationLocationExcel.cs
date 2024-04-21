// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FormationLocationExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FormationLocationExcel GetRootAsFormationLocationExcel(ByteBuffer _bb) { return GetRootAsFormationLocationExcel(_bb, new FormationLocationExcel()); }
  public static FormationLocationExcel GetRootAsFormationLocationExcel(ByteBuffer _bb, FormationLocationExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FormationLocationExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float SlotZ(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SlotZLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSlotZBytes() { return __p.__vector_as_span<float>(8, 4); }
#else
  public ArraySegment<byte>? GetSlotZBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public float[] GetSlotZArray() { return __p.__vector_as_array<float>(8); }
  public float SlotX(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SlotXLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSlotXBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetSlotXBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetSlotXArray() { return __p.__vector_as_array<float>(10); }

  public static Offset<SCHALE.Common.FlatData.FormationLocationExcel> CreateFormationLocationExcel(FlatBufferBuilder builder,
      long Id = 0,
      long GroupID = 0,
      VectorOffset SlotZOffset = default(VectorOffset),
      VectorOffset SlotXOffset = default(VectorOffset)) {
    builder.StartTable(4);
    FormationLocationExcel.AddGroupID(builder, GroupID);
    FormationLocationExcel.AddId(builder, Id);
    FormationLocationExcel.AddSlotX(builder, SlotXOffset);
    FormationLocationExcel.AddSlotZ(builder, SlotZOffset);
    return FormationLocationExcel.EndFormationLocationExcel(builder);
  }

  public static void StartFormationLocationExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddGroupID(FlatBufferBuilder builder, long groupID) { builder.AddLong(1, groupID, 0); }
  public static void AddSlotZ(FlatBufferBuilder builder, VectorOffset slotZOffset) { builder.AddOffset(2, slotZOffset.Value, 0); }
  public static VectorOffset CreateSlotZVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSlotZVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSlotZVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSlotZVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSlotZVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSlotX(FlatBufferBuilder builder, VectorOffset slotXOffset) { builder.AddOffset(3, slotXOffset.Value, 0); }
  public static VectorOffset CreateSlotXVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSlotXVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSlotXVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSlotXVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSlotXVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.FormationLocationExcel> EndFormationLocationExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FormationLocationExcel>(o);
  }
}


static public class FormationLocationExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GroupID*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*SlotZ*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*SlotX*/, 4 /*float*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
