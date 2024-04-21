// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WorldRaidFavorBuffExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WorldRaidFavorBuffExcelTable GetRootAsWorldRaidFavorBuffExcelTable(ByteBuffer _bb) { return GetRootAsWorldRaidFavorBuffExcelTable(_bb, new WorldRaidFavorBuffExcelTable()); }
  public static WorldRaidFavorBuffExcelTable GetRootAsWorldRaidFavorBuffExcelTable(ByteBuffer _bb, WorldRaidFavorBuffExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidFavorBuffExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.WorldRaidFavorBuffExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.WorldRaidFavorBuffExcel?)(new SCHALE.Common.FlatData.WorldRaidFavorBuffExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcelTable> CreateWorldRaidFavorBuffExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    WorldRaidFavorBuffExcelTable.AddDataList(builder, DataListOffset);
    return WorldRaidFavorBuffExcelTable.EndWorldRaidFavorBuffExcelTable(builder);
  }

  public static void StartWorldRaidFavorBuffExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcelTable> EndWorldRaidFavorBuffExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.WorldRaidFavorBuffExcelTable>(o);
  }
}


static public class WorldRaidFavorBuffExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, SCHALE.Common.FlatData.WorldRaidFavorBuffExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
