﻿namespace Org.BouncyCastle.Crypto.Tls
{
    using System;
    using System.IO;

    public class NewSessionTicket
    {
        protected readonly long mTicketLifetimeHint;
        protected readonly byte[] mTicket;

        public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
        {
            this.mTicketLifetimeHint = ticketLifetimeHint;
            this.mTicket = ticket;
        }

        public virtual void Encode(Stream output)
        {
            TlsUtilities.WriteUint32(this.mTicketLifetimeHint, output);
            TlsUtilities.WriteOpaque16(this.mTicket, output);
        }

        public static NewSessionTicket Parse(Stream input)
        {
            long ticketLifetimeHint = TlsUtilities.ReadUint32(input);
            return new NewSessionTicket(ticketLifetimeHint, TlsUtilities.ReadOpaque16(input));
        }

        public virtual long TicketLifetimeHint =>
            this.mTicketLifetimeHint;

        public virtual byte[] Ticket =>
            this.mTicket;
    }
}

