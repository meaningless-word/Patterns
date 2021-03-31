using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
	class Application
	{
		public DbConnection DbConnection { get; set; }
		public void Launch(string dbServer)
		{
			DbConnection = DbConnection.GetConnectionInstance(dbServer);
		}
	}
}
