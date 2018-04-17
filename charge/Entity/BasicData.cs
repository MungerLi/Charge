using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ĞŞ¸ÄÃû×Ö¿Õ¼ä
{
	public class BasicData
	{
		private DateTime serial;
		public DateTime Serial
		{
			get { return serial; }
			set { serial = value; }
		}
	
		private decimal rate;
		public decimal Rate
		{
			get { return rate; }
			set { rate = value; }
		}
	
		private int unitime;
		public int Unitime
		{
			get { return unitime; }
			set { unitime = value; }
		}
	
		private int leasttime;
		public int Leasttime
		{
			get { return leasttime; }
			set { leasttime = value; }
		}
	
		private int readytime;
		public int Readytime
		{
			get { return readytime; }
			set { readytime = value; }
		}
	
		private decimal leastcash;
		public decimal Leastcash
		{
			get { return leastcash; }
			set { leastcash = value; }
		}
	
		private string head;
		public string Head
		{
			get { return head; }
			set { head = value; }
		}
	}
}