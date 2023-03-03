﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _14_Encapsulation
{
    internal class clsBank
    {
        #region Normal Durum

        public long AcountNumber; // Hesap No
        public string Name;
        public int Balance; //miktar

        public void GetBalance()
        {

        }

        public void WithdrawAccount()
        {

        }

        public void depoasit()
        {


        }

        #endregion


        #region Getter setter

        //private double balance; // burada dışarıya kapalı bir dğeişken tanımı var

        //// set - get methodlarının tanımlanması

        ////public getter method: balance değişkeninde tutulan değeri almak için 

        //public double GetBalanceCaps()
        //{
        //    //burada farklı işlemler var...
        //    return this.balance;
        //}

        ////public setter method: bu metot balance değişkeninize tutalan değeri set/değiştirmek/güncellemek
        //public void SetBalanceCaps(double balance)
        //{
        //   this.balance = balance;// sen benim kendi değişkenimi güncelleyeceksin
        //}




        #endregion


        #region Eğer sınıfı tasarlarken Kapsülleme prensibine uyulmazsa ne olur?


        public int Amount;

        public int GetAmount()
        {
            return Amount;
        }

        public void SetAmount (int Amount)
        {
            if(Amount>0) {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("lütfen pozitif bir sayi giriniz!");
            }

          
        }


        #endregion




        #region Properteis / Değişkenlere de uygulanabilir


        private int _Amount1;

        public int Amount1
        {
            get
            {
                return _Amount1;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Lütfen bir pozitif değer giriniz: ");
                }
                else
                {
                    _Amount1 = value;
                }
            }
        }


        public int _Amount { get; set; }




        #endregion




    }
}
