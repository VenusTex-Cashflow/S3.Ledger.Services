namespace T3.S3Ledger.Api
{
    public class Enums
    {
        public enum CustomerType
        {
            None,
            BillToBill,
            Normal

        }

        public enum PaymentType
        {
            None,
            BillToBill,
            Normal
        }

        public enum Role
        {
            SystemAdmin,
            OrgAdmin,
            Manager,
            User
        }

        public enum PayMode
        {
            None,
            Cash,
            Cheque,
            Debit,
            Credit
        }

        public enum BusinessType
        {
            None,
            Retail,
            Wholesale,
            Partner
        }

        public enum InvoiceStatus
        {
            None,
            Outstanding,
            PaymentReceived,
            Completed
        }

        public enum ChequeType
        {
            None,
            Cash,
            Account
        }

        public enum AddressType
        {
            None,
            Billing,
            Shipping
        }
    }
}
