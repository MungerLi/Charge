///////////////////////////////////////////////////////////
//  Student.cs
//  Implementation of the Class Student
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
    public class Student
    {

        public int StudentNo { set; get; }
        public string Name { set; get; }
        public string Sex { set; get; }
        public string Department { set; get; }
        public string Grade { set; get; }
        public string Class { set; get; }
        public string Notes { set; get; }
        public Card m_Card { set; get; }

        public Student()
        {

        }

        ~Student()
        {

        }

        /// 
        /// <param name="StudentNo"></param>
        public void PK_Student(int StudentNo)
        {

        }

    }//end Student
}