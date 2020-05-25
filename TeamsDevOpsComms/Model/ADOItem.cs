using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsDevOpsComms.Model
{
    public class ADOItem
    {
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string priority;

		public string Priority
		{
			get { return priority; }
			set { priority = value; }
		}

		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}


		private string discription;

		public string Discription
		{
			get { return discription; }
			set { discription = value; }
		}


	}
}
