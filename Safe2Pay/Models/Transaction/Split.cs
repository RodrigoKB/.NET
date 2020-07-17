﻿namespace Safe2Pay.Models
{
    public class Split
    {
        public int IdReceiver { get; set; }
        public string Identity { get; set; }
        public bool IsPayTax { get; set; }
        public decimal Amount { get; set; }
        public EnumTaxType CodeTaxType { get; set; }
        public EnumReceiverType CodeReceiverType { get; set; }
    }
    
    public enum EnumTaxType
    {
        None = 0,
        Percentage = 1,
        Amount = 2
    }

    public enum EnumReceiverType
    {
        None = 0,
        Merchant = 1,
        Subaccount = 2
    }
}