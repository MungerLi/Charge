using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class LineLog
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
	
		private string computer;
		public string Computer
		{
			get { return computer; }
			set { computer = value; }
		}
	
		private DateTime onData;
		public DateTime OnData
		{
			get { return onData; }
			set { onData = value; }
		}
	
		private DateTime ofData;
		public DateTime OfData
		{
			get { return ofData; }
			set { ofData = value; }
		}
	
		private int mins;
		public int Mins
		{
			get { return mins; }
			set { mins = value; }
		}
	
		private decimal cash;
		public decimal Cash
		{
			get { return cash; }
			set { cash = value; }
		}
	}
}