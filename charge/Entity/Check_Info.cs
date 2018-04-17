using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class Check_Info
	{
		private int serial;
		public int Serial
		{
			get { return serial; }
			set { serial = value; }
		}
	
		private decimal checkCash;
		public decimal CheckCash
		{
			get { return checkCash; }
			set { checkCash = value; }
		}
	
		private decimal rechCash;
		public decimal RechCash
		{
			get { return rechCash; }
			set { rechCash = value; }
		}
	
		private decimal cancelCash;
		public decimal CancelCash
		{
			get { return cancelCash; }
			set { cancelCash = value; }
		}
	
		private decimal remainCash;
		public decimal RemainCash
		{
			get { return remainCash; }
			set { remainCash = value; }
		}
	
		private DateTime checkDate;
		public DateTime CheckDate
		{
			get { return checkDate; }
			set { checkDate = value; }
		}
	
		private string head;
		public string Head
		{
			get { return head; }
			set { head = value; }
		}
	}
}