// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaCraftNodeGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GachaCraftNodeGroupExcel GetRootAsGachaCraftNodeGroupExcel(ByteBuffer _bb) { return GetRootAsGachaCraftNodeGroupExcel(_bb, new GachaCraftNodeGroupExcel()); }
  public static GachaCraftNodeGroupExcel GetRootAsGachaCraftNodeGroupExcel(ByteBuffer _bb, GachaCraftNodeGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaCraftNodeGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long NodeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GachaGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ProbWeight { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.GachaCraftNodeGroupExcel> CreateGachaCraftNodeGroupExcel(FlatBufferBuilder builder,
      long NodeId = 0,
      long GachaGroupId = 0,
      long ProbWeight = 0) {
    builder.StartTable(3);
    GachaCraftNodeGroupExcel.AddProbWeight(builder, ProbWeight);
    GachaCraftNodeGroupExcel.AddGachaGroupId(builder, GachaGroupId);
    GachaCraftNodeGroupExcel.AddNodeId(builder, NodeId);
    return GachaCraftNodeGroupExcel.EndGachaCraftNodeGroupExcel(builder);
  }

  public static void StartGachaCraftNodeGroupExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddNodeId(FlatBufferBuilder builder, long nodeId) { builder.AddLong(0, nodeId, 0); }
  public static void AddGachaGroupId(FlatBufferBuilder builder, long gachaGroupId) { builder.AddLong(1, gachaGroupId, 0); }
  public static void AddProbWeight(FlatBufferBuilder builder, long probWeight) { builder.AddLong(2, probWeight, 0); }
  public static Offset<SCHALE.Common.FlatData.GachaCraftNodeGroupExcel> EndGachaCraftNodeGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.GachaCraftNodeGroupExcel>(o);
  }
}


static public class GachaCraftNodeGroupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*NodeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GachaGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ProbWeight*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
