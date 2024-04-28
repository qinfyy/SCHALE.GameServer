﻿using MongoDB.Driver.Linq;
using SCHALE.Common.Database;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;
using Serilog;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Mission : ProtocolHandlerBase
    {
        private ISessionKeyService sessionKeyService;
        private SCHALEContext context;

        public Mission(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
        }

        [ProtocolHandler(Protocol.Mission_List)]
        public ResponsePacket ListHandler(MissionListRequest req)
        {
            Log.Information($"MissionListRequest EventContentId: {req.EventContentId}");

            var missionProgresses = context.MissionProgresses.Where(x => x.AccountServerId == sessionKeyService.GetAccount(req.SessionKey).ServerId).ToList();

            return new MissionListResponse
            {
                ProgressDBs = missionProgresses
            };
        }

        [ProtocolHandler(Protocol.Mission_GuideMissionSeasonList)]
        public ResponsePacket GuideMissionSeasonListHandler(GuideMissionSeasonListRequest req)
        {
            return new GuideMissionSeasonListResponse()
            {

            };
        }
    }
}
