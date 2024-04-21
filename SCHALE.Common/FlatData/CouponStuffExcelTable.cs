// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CouponStuffExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CouponStuffExcelTable GetRootAsCouponStuffExcelTable(ByteBuffer _bb) { return GetRootAsCouponStuffExcelTable(_bb, new CouponStuffExcelTable()); }
  public static CouponStuffExcelTable GetRootAsCouponStuffExcelTable(ByteBuffer _bb, CouponStuffExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CouponStuffExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.CouponStuffExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.CouponStuffExcel?)(new SCHALE.Common.FlatData.CouponStuffExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.CouponStuffExcelTable> CreateCouponStuffExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    CouponStuffExcelTable.AddDataList(builder, DataListOffset);
    return CouponStuffExcelTable.EndCouponStuffExcelTable(builder);
  }

  public static void StartCouponStuffExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.CouponStuffExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.CouponStuffExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.CouponStuffExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.CouponStuffExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.CouponStuffExcelTable> EndCouponStuffExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CouponStuffExcelTable>(o);
  }
}


static public class CouponStuffExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, SCHALE.Common.FlatData.CouponStuffExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
