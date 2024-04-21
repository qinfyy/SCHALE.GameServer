// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RecipeSelectionAutoUseExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RecipeSelectionAutoUseExcel GetRootAsRecipeSelectionAutoUseExcel(ByteBuffer _bb) { return GetRootAsRecipeSelectionAutoUseExcel(_bb, new RecipeSelectionAutoUseExcel()); }
  public static RecipeSelectionAutoUseExcel GetRootAsRecipeSelectionAutoUseExcel(ByteBuffer _bb, RecipeSelectionAutoUseExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeSelectionAutoUseExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ParcelType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long TargetItemId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Priority(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PriorityLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPriorityBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetPriorityBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetPriorityArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<SCHALE.Common.FlatData.RecipeSelectionAutoUseExcel> CreateRecipeSelectionAutoUseExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.ParcelType ParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long TargetItemId = 0,
      VectorOffset PriorityOffset = default(VectorOffset)) {
    builder.StartTable(4);
    RecipeSelectionAutoUseExcel.AddTargetItemId(builder, TargetItemId);
    RecipeSelectionAutoUseExcel.AddId(builder, Id);
    RecipeSelectionAutoUseExcel.AddPriority(builder, PriorityOffset);
    RecipeSelectionAutoUseExcel.AddParcelType(builder, ParcelType);
    return RecipeSelectionAutoUseExcel.EndRecipeSelectionAutoUseExcel(builder);
  }

  public static void StartRecipeSelectionAutoUseExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType parcelType) { builder.AddInt(1, (int)parcelType, 0); }
  public static void AddTargetItemId(FlatBufferBuilder builder, long targetItemId) { builder.AddLong(2, targetItemId, 0); }
  public static void AddPriority(FlatBufferBuilder builder, VectorOffset priorityOffset) { builder.AddOffset(3, priorityOffset.Value, 0); }
  public static VectorOffset CreatePriorityVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePriorityVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePriorityVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePriorityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPriorityVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.RecipeSelectionAutoUseExcel> EndRecipeSelectionAutoUseExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.RecipeSelectionAutoUseExcel>(o);
  }
}


static public class RecipeSelectionAutoUseExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*TargetItemId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*Priority*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
