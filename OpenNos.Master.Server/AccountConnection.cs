﻿using System;

namespace OpenNos.Master.Library.Data
{
    internal class AccountConnection
    {
        #region Instantiation

        public AccountConnection(long accountId, long session)
        {
            AccountId = accountId;
            SessionId = session;
            LastPulse = DateTime.Now;
        }

        #endregion

        #region Properties

        public long AccountId { get; private set; }

        public long CharacterId { get; set; }

        public DateTime LastPulse { get; set; }

        public WorldServer ConnectedWorld { get; set; }

        public long SessionId { get; private set; }

        #endregion
    }
}