///////////////////////////////////////////////////////////
//  Charge.cs
//  Implementation of the Class Charge
//  Generated by Enterprise Architect
//  Created on:      08-11��-2016 19:43:52
//  Original author: SweetyoYY
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Entity
{
    public class Charge
    {

        public string CardNo { set; get; }
        public string UserID { set; get; }
        public int AddMoney { set; get; }
        public int StudentNo { set; get; }
        public DateTime Date { set; get; }
        public TimeSpan  Time { set; get; }
        public string IsCheck { set; get; }
        //public User m_User;

        public Charge()
        {

        }

        ~Charge()
        {

        }

        /// 
        /// <param name="CardNo"></param>
        public void PK_Charge(string CardNo)
        {

        }

    }
}//end Charge