///////////////////////////////////////////////////////////
//  BasicData.cs
//  Implementation of the Class BasicData
//  Generated by Enterprise Architect
//  Created on:      08-11��-2016 19:43:51
//  Original author: SweetyoYY
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Entity
{
    public class BasicData
    {


        public int Rate { set; get; }
        public int TmpRate { set; get; }
        public int UntilTime { set; get; }
        public int LeastTiime { set; get; }
        public int PreparyTime { set; get; }
        public int LeastMoney { set; get; }
        public DateTime Date { set; get; }
        public DateTime Time { set; get; }
        public string UserID { set; get; }
        //public user  m_User;

        public BasicData()
        {

        }

        ~BasicData()
        {

        }
    }

}//end BasicData