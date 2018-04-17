using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class ReCharge
	{
		private int serial;
		public int Serial
		{
			get { return serial; }
			set { serial = value; }
		}
	
		private string cardNo;
		public string CardNo
		{
			get { return cardNo; }
			set { cardNo = value; }
		}
	
		private decimal rechCash;
		public decimal RechCash
		{
			get { return rechCash; }
			set { rechCash = value; }
		}
	
		private decimal balance;
		public decimal Balance
		{
			get { return balance; }
			set { balance = value; }
		}
	
		private DateTime rechDate;
		public DateTime RechDate
		{
			get { return rechDate; }
			set { rechDate = value; }
		}
	
		private string userID;
		public string UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		private string computer;
		public string Computer
		{
			get { return computer; }
			set { computer = value; }
		}
	}
}