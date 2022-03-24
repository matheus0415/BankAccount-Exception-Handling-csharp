﻿using System;
using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {   
            Balance += amount;
        }
        public void Withdraw(double amount)
        {   
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Exceeded withdraw amount limit!");
            }
            if (amount > Balance)
            {
                throw new DomainException("Insufficent funds");
            }
            Balance -= amount;
        }
    }
}
