using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Card
	{
		private string cardNo;
		public string CardNo
		{
			get { return cardNo; }
			set { cardNo = value; }
		}
	
		private string studentNo;
		public string StudentNo
		{
			get { return studentNo; }
			set { studentNo = value; }
		}
	
		private decimal balance;
		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}
	
		private string userID;
		public string UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		private bool state;
		public bool State
		{
			get { return state; }
			set { state = value; }
		}
	
		private DateTime regdata;
		public DateTime Regdata
		{
			get { return regdata; }
			set { regdata = value; }
		}
	
		private bool ischack;
		public bool Ischack
		{
			get { return ischack; }
			set { ischack = value; }
		}
	}
}