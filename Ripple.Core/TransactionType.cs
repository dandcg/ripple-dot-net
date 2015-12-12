using System;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Ripple.Core.Util;

namespace Ripple.Core
{
    public class TransactionType : SerializedEnumItem<ushort>
    {
        public class Enumeration : SerializedEnumeration<TransactionType, ushort>{}
        public static Enumeration Values = new Enumeration();
        private TransactionType(string reference, int ordinal) : base(reference, ordinal){}

        private static TransactionType Add(string name, int ordinal)
        {
            return Values.AddEnum(new TransactionType(name, ordinal));
        }

        public static readonly TransactionType Invalid = Add(nameof(Invalid), -1);
        public static readonly TransactionType Payment = Add(nameof(Payment), 0);
        public static readonly TransactionType Claim = Add(nameof(Claim), 1);
        public static readonly TransactionType WalletAdd = Add(nameof(WalletAdd), 2);
        public static readonly TransactionType AccountSet = Add(nameof(AccountSet), 3);
        public static readonly TransactionType PasswordFund = Add(nameof(PasswordFund), 4);
        public static readonly TransactionType SetRegularKey = Add(nameof(SetRegularKey), 5);
        public static readonly TransactionType NickNameSet = Add(nameof(NickNameSet), 6);
        public static readonly TransactionType OfferCreate = Add(nameof(OfferCreate), 7);
        public static readonly TransactionType OfferCancel = Add(nameof(OfferCancel), 8);
        public static readonly TransactionType Contract = Add(nameof(Contract), 9);
        public static readonly TransactionType TicketCreate = Add(nameof(TicketCreate), 10);
        public static readonly TransactionType TicketCancel = Add(nameof(TicketCancel), 11);
        public static readonly TransactionType SignerListSet = Add(nameof(SignerListSet), 12);
        public static readonly TransactionType TrustSet = Add(nameof(TrustSet), 20);
        public static readonly TransactionType EnableAmendment = Add(nameof(EnableAmendment), 100);
        public static readonly TransactionType SetFee = Add(nameof(SetFee), 101);
    }
}