// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Position : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static Position GetRootAsPosition(ByteBuffer _bb) { return GetRootAsPosition(_bb, new Position()); }
  public static Position GetRootAsPosition(ByteBuffer _bb, Position obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Position __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.Position> CreatePosition(FlatBufferBuilder builder,
      float X = 0.0f,
      float Z = 0.0f) {
    builder.StartTable(2);
    Position.AddZ(builder, Z);
    Position.AddX(builder, X);
    return Position.EndPosition(builder);
  }

  public static void StartPosition(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(0, x, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(1, z, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.Position> EndPosition(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.Position>(o);
  }
}


static public class PositionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Z*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
