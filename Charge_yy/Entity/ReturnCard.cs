///////////////////////////////////////////////////////////
//  ReturnCard.cs
//  Implementation of the Class ReturnCard
//  Generated by Enterprise Architect
//  Created on:      08-11��-2016 19:43:53
//  Original author: SweetyoYY
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Entity
{
    public class ReturnCard
    {

        public int CardNo { set; get; }
        public string UserID { set; get; }
        public int  ReturnMoney { set; get; }
        public DateTime Date { set; get; }
        public TimeSpan Time { set; get; }
        public string IsCheck { set; get; }
        public Entity.User m_User { set; get; }

        public ReturnCard()
        {

        }

        ~ReturnCard()
        {

        }

        /// 
        /// <param name="CardNo"></param>
        public void PK_ReturnCard(int CardNo)
        {

        }

    }
}//end ReturnCard