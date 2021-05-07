using System.Collections.Generic;

namespace T3.S3Ledger.Api
{
    internal static class Constant
    {
        internal static readonly string TransactionDb = "TransactionDB";
        internal static readonly string ManageDb = "ManageDB";
        internal static readonly string HostPath = "HostPath";
        internal static IDictionary<string, string> DbConnectionSettings = new Dictionary<string, string>();
    }
}
