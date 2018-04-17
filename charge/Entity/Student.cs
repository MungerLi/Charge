using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ĞŞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Student
	{
		private string studentNo;
		public string StudentNo
		{
			get { return studentNo; }
			set { studentNo = value; }
		}
	
		private string cardNo;
		public string CardNo
		{
			get { return cardNo; }
			set { cardNo = value; }
		}
	
		private string studentName;
		public string StudentName
		{
			get { return studentName; }
			set { studentName = value; }
		}
	
		private bool sex;
		public bool Sex
		{
			get { return sex; }
			set { sex = value; }
		}
	
		private string department;
		public string Department
		{
			get { return department; }
			set { department = value; }
		}
	
		private string grade;
		public string Grade
		{
			get { return grade; }
			set { grade = value; }
		}
	
		private string specialty;
		public string Specialty
		{
			get { return specialty; }
			set { specialty = value; }
		}
	}
}