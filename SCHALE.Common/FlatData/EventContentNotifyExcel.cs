// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentNotifyExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb) { return GetRootAsEventContentNotifyExcel(_bb, new EventContentNotifyExcel()); }
  public static EventContentNotifyExcel GetRootAsEventContentNotifyExcel(ByteBuffer _bb, EventContentNotifyExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentNotifyExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(8); }
  public SCHALE.Common.FlatData.EventNotifyType EventNotifyType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.EventNotifyType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventNotifyType.RewardIncreaseEvent; } }
  public SCHALE.Common.FlatData.EventTargetType EventTargetType { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventTargetType.WeekDungeon; } }
  public SCHALE.Common.FlatData.EventTargetType ShortcutEventTargetType { get { int o = __p.__offset(14); return o != 0 ? (SCHALE.Common.FlatData.EventTargetType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventTargetType.WeekDungeon; } }
  public bool IsShortcutEnable { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.EventContentNotifyExcel> CreateEventContentNotifyExcel(FlatBufferBuilder builder,
      int Id = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset),
      SCHALE.Common.FlatData.EventNotifyType EventNotifyType = SCHALE.Common.FlatData.EventNotifyType.RewardIncreaseEvent,
      SCHALE.Common.FlatData.EventTargetType EventTargetType = SCHALE.Common.FlatData.EventTargetType.WeekDungeon,
      SCHALE.Common.FlatData.EventTargetType ShortcutEventTargetType = SCHALE.Common.FlatData.EventTargetType.WeekDungeon,
      bool IsShortcutEnable = false) {
    builder.StartTable(7);
    EventContentNotifyExcel.AddShortcutEventTargetType(builder, ShortcutEventTargetType);
    EventContentNotifyExcel.AddEventTargetType(builder, EventTargetType);
    EventContentNotifyExcel.AddEventNotifyType(builder, EventNotifyType);
    EventContentNotifyExcel.AddIconPath(builder, IconPathOffset);
    EventContentNotifyExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentNotifyExcel.AddId(builder, Id);
    EventContentNotifyExcel.AddIsShortcutEnable(builder, IsShortcutEnable);
    return EventContentNotifyExcel.EndEventContentNotifyExcel(builder);
  }

  public static void StartEventContentNotifyExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(1, localizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(2, iconPathOffset.Value, 0); }
  public static void AddEventNotifyType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventNotifyType eventNotifyType) { builder.AddInt(3, (int)eventNotifyType, 0); }
  public static void AddEventTargetType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventTargetType eventTargetType) { builder.AddInt(4, (int)eventTargetType, 0); }
  public static void AddShortcutEventTargetType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventTargetType shortcutEventTargetType) { builder.AddInt(5, (int)shortcutEventTargetType, 0); }
  public static void AddIsShortcutEnable(FlatBufferBuilder builder, bool isShortcutEnable) { builder.AddBool(6, isShortcutEnable, false); }
  public static Offset<SCHALE.Common.FlatData.EventContentNotifyExcel> EndEventContentNotifyExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentNotifyExcel>(o);
  }
}


static public class EventContentNotifyExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*IconPath*/, false)
      && verifier.VerifyField(tablePos, 10 /*EventNotifyType*/, 4 /*SCHALE.Common.FlatData.EventNotifyType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*EventTargetType*/, 4 /*SCHALE.Common.FlatData.EventTargetType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ShortcutEventTargetType*/, 4 /*SCHALE.Common.FlatData.EventTargetType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*IsShortcutEnable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
