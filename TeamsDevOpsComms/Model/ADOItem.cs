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

        private type type;

        public type Type
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

        public string Module { get; set; }

        public string Status { get; set; }

        public string CustomerReferenceNumber { get; set; }

    }

    public enum type
    {
        SR,
        W,
        Q,
        O,
        incident
    }
}
