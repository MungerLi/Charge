using System;
using System.Collections.Generic;
using System.Text;

namespace Entity //ÐÞ¸ÄÃû×Ö¿Õ¼ä
{
	public class WorkLog
	{
		private string serial;
		public string Serial
		{
			get { return serial; }
			set { serial = value; }
		}
	
		private string userID;
		public string UserID
		{
			get { return userID; }
			set { userID = value; }
		}
	
		private string loginDate;
		public string LoginDate
		{
			get { return loginDate; }
			set { loginDate = value; }
		}
	
		private string logoutDate;
		public string LogoutDate
		{
			get { return logoutDate; }
			set { logoutDate = value; }
		}
	
		private string computer;
		public string Computer
		{
			get { return computer; }
			set { computer = value; }
		}
	
		private string state;
		public string State
		{
			get { return state; }
			set { state = value; }
		}
	}
}