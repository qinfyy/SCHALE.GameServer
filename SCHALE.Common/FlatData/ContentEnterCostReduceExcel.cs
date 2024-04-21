// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ContentEnterCostReduceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ContentEnterCostReduceExcel GetRootAsContentEnterCostReduceExcel(ByteBuffer _bb) { return GetRootAsContentEnterCostReduceExcel(_bb, new ContentEnterCostReduceExcel()); }
  public static ContentEnterCostReduceExcel GetRootAsContentEnterCostReduceExcel(ByteBuffer _bb, ContentEnterCostReduceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ContentEnterCostReduceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EnterCostReduceGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ContentType ContentType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ContentType.None; } }
  public long StageId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ReduceEnterCostType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long ReduceEnterCostId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ReduceAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.ContentEnterCostReduceExcel> CreateContentEnterCostReduceExcel(FlatBufferBuilder builder,
      long EnterCostReduceGroupId = 0,
      SCHALE.Common.FlatData.ContentType ContentType = SCHALE.Common.FlatData.ContentType.None,
      long StageId = 0,
      SCHALE.Common.FlatData.ParcelType ReduceEnterCostType = SCHALE.Common.FlatData.ParcelType.None,
      long ReduceEnterCostId = 0,
      long ReduceAmount = 0) {
    builder.StartTable(6);
    ContentEnterCostReduceExcel.AddReduceAmount(builder, ReduceAmount);
    ContentEnterCostReduceExcel.AddReduceEnterCostId(builder, ReduceEnterCostId);
    ContentEnterCostReduceExcel.AddStageId(builder, StageId);
    ContentEnterCostReduceExcel.AddEnterCostReduceGroupId(builder, EnterCostReduceGroupId);
    ContentEnterCostReduceExcel.AddReduceEnterCostType(builder, ReduceEnterCostType);
    ContentEnterCostReduceExcel.AddContentType(builder, ContentType);
    return ContentEnterCostReduceExcel.EndContentEnterCostReduceExcel(builder);
  }

  public static void StartContentEnterCostReduceExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddEnterCostReduceGroupId(FlatBufferBuilder builder, long enterCostReduceGroupId) { builder.AddLong(0, enterCostReduceGroupId, 0); }
  public static void AddContentType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ContentType contentType) { builder.AddInt(1, (int)contentType, 0); }
  public static void AddStageId(FlatBufferBuilder builder, long stageId) { builder.AddLong(2, stageId, 0); }
  public static void AddReduceEnterCostType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType reduceEnterCostType) { builder.AddInt(3, (int)reduceEnterCostType, 0); }
  public static void AddReduceEnterCostId(FlatBufferBuilder builder, long reduceEnterCostId) { builder.AddLong(4, reduceEnterCostId, 0); }
  public static void AddReduceAmount(FlatBufferBuilder builder, long reduceAmount) { builder.AddLong(5, reduceAmount, 0); }
  public static Offset<SCHALE.Common.FlatData.ContentEnterCostReduceExcel> EndContentEnterCostReduceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ContentEnterCostReduceExcel>(o);
  }
}


static public class ContentEnterCostReduceExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EnterCostReduceGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ContentType*/, 4 /*SCHALE.Common.FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*StageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ReduceEnterCostType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ReduceEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*ReduceAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
