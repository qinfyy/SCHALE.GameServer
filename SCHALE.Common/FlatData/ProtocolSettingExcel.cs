// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ProtocolSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ProtocolSettingExcel GetRootAsProtocolSettingExcel(ByteBuffer _bb) { return GetRootAsProtocolSettingExcel(_bb, new ProtocolSettingExcel()); }
  public static ProtocolSettingExcel GetRootAsProtocolSettingExcel(ByteBuffer _bb, ProtocolSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ProtocolSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Protocol { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProtocolBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetProtocolBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetProtocolArray() { return __p.__vector_as_array<byte>(4); }
  public SCHALE.Common.FlatData.OpenConditionContent OpenConditionContent { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.OpenConditionContent)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.OpenConditionContent.Shop; } }
  public bool Currency { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Inventory { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Mail { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.ProtocolSettingExcel> CreateProtocolSettingExcel(FlatBufferBuilder builder,
      StringOffset ProtocolOffset = default(StringOffset),
      SCHALE.Common.FlatData.OpenConditionContent OpenConditionContent = SCHALE.Common.FlatData.OpenConditionContent.Shop,
      bool Currency = false,
      bool Inventory = false,
      bool Mail = false) {
    builder.StartTable(5);
    ProtocolSettingExcel.AddOpenConditionContent(builder, OpenConditionContent);
    ProtocolSettingExcel.AddProtocol(builder, ProtocolOffset);
    ProtocolSettingExcel.AddMail(builder, Mail);
    ProtocolSettingExcel.AddInventory(builder, Inventory);
    ProtocolSettingExcel.AddCurrency(builder, Currency);
    return ProtocolSettingExcel.EndProtocolSettingExcel(builder);
  }

  public static void StartProtocolSettingExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddProtocol(FlatBufferBuilder builder, StringOffset protocolOffset) { builder.AddOffset(0, protocolOffset.Value, 0); }
  public static void AddOpenConditionContent(FlatBufferBuilder builder, SCHALE.Common.FlatData.OpenConditionContent openConditionContent) { builder.AddInt(1, (int)openConditionContent, 0); }
  public static void AddCurrency(FlatBufferBuilder builder, bool currency) { builder.AddBool(2, currency, false); }
  public static void AddInventory(FlatBufferBuilder builder, bool inventory) { builder.AddBool(3, inventory, false); }
  public static void AddMail(FlatBufferBuilder builder, bool mail) { builder.AddBool(4, mail, false); }
  public static Offset<SCHALE.Common.FlatData.ProtocolSettingExcel> EndProtocolSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ProtocolSettingExcel>(o);
  }
}


static public class ProtocolSettingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Protocol*/, false)
      && verifier.VerifyField(tablePos, 6 /*OpenConditionContent*/, 4 /*SCHALE.Common.FlatData.OpenConditionContent*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Currency*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*Inventory*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*Mail*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
