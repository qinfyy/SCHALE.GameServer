// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentShopRefreshExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentShopRefreshExcel GetRootAsEventContentShopRefreshExcel(ByteBuffer _bb) { return GetRootAsEventContentShopRefreshExcel(_bb, new EventContentShopRefreshExcel()); }
  public static EventContentShopRefreshExcel GetRootAsEventContentShopRefreshExcel(ByteBuffer _bb, EventContentShopRefreshExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentShopRefreshExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool IsLegacy { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long GoodsId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DisplayOrder { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ShopCategoryType CategoryType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ShopCategoryType.General; } }
  public int RefreshGroup { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BuyReportEventName { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuyReportEventNameBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetBuyReportEventNameBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetBuyReportEventNameArray() { return __p.__vector_as_array<byte>(22); }

  public static Offset<SCHALE.Common.FlatData.EventContentShopRefreshExcel> CreateEventContentShopRefreshExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long Id = 0,
      uint LocalizeEtcId = 0,
      bool IsLegacy = false,
      long GoodsId = 0,
      long DisplayOrder = 0,
      SCHALE.Common.FlatData.ShopCategoryType CategoryType = SCHALE.Common.FlatData.ShopCategoryType.General,
      int RefreshGroup = 0,
      int Prob = 0,
      StringOffset BuyReportEventNameOffset = default(StringOffset)) {
    builder.StartTable(10);
    EventContentShopRefreshExcel.AddDisplayOrder(builder, DisplayOrder);
    EventContentShopRefreshExcel.AddGoodsId(builder, GoodsId);
    EventContentShopRefreshExcel.AddId(builder, Id);
    EventContentShopRefreshExcel.AddEventContentId(builder, EventContentId);
    EventContentShopRefreshExcel.AddBuyReportEventName(builder, BuyReportEventNameOffset);
    EventContentShopRefreshExcel.AddProb(builder, Prob);
    EventContentShopRefreshExcel.AddRefreshGroup(builder, RefreshGroup);
    EventContentShopRefreshExcel.AddCategoryType(builder, CategoryType);
    EventContentShopRefreshExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentShopRefreshExcel.AddIsLegacy(builder, IsLegacy);
    return EventContentShopRefreshExcel.EndEventContentShopRefreshExcel(builder);
  }

  public static void StartEventContentShopRefreshExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(1, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool isLegacy) { builder.AddBool(3, isLegacy, false); }
  public static void AddGoodsId(FlatBufferBuilder builder, long goodsId) { builder.AddLong(4, goodsId, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long displayOrder) { builder.AddLong(5, displayOrder, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ShopCategoryType categoryType) { builder.AddInt(6, (int)categoryType, 0); }
  public static void AddRefreshGroup(FlatBufferBuilder builder, int refreshGroup) { builder.AddInt(7, refreshGroup, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(8, prob, 0); }
  public static void AddBuyReportEventName(FlatBufferBuilder builder, StringOffset buyReportEventNameOffset) { builder.AddOffset(9, buyReportEventNameOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.EventContentShopRefreshExcel> EndEventContentShopRefreshExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentShopRefreshExcel>(o);
  }
}


static public class EventContentShopRefreshExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IsLegacy*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*GoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*DisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*CategoryType*/, 4 /*SCHALE.Common.FlatData.ShopCategoryType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*RefreshGroup*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 22 /*BuyReportEventName*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
