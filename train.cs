using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainOrgnz
{
    class train
    {
        public string TrainNum { get; set; }
        public string WagType { get; set; }
        public string Ticket { get; set; }


        public void Traint(string tt,string wt, string tk)
        {
            this.TrainNum = tt;
            this.WagType = wt;
            this.Ticket = tk;
        }

        public void ConnDB()
        {
            ConnectDB condb = new ConnectDB();
            condb.OleConn();

        }

        internal object AddEventAsync(Event testEvent)
        {
            throw new NotImplementedException();
        }

        internal static object GetEventAsync(object id)
        {
            throw new NotImplementedException();
        }

        internal object SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
