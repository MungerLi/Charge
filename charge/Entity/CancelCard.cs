using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class CancelCard
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
	
		private decimal cancelCash;
		public decimal CancelCash
		{
			get { return cancelCash; }
			set { cancelCash = value; }
		}
	
		private DateTime cancelDate;
		public DateTime CancelDate
		{
			get { return cancelDate; }
			set { cancelDate = value; }
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