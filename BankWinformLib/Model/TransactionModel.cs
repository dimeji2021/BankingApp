﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppCore.Model
{
   public class TransactionModel
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public string Balance { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
