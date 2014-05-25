using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Converter
{
    using System.Data;

    public class Global : System.Web.HttpApplication
    {
        private static IDictionary<string, string> _currencies = new Dictionary<string, string>();

        public static IDictionary<string, string> Currencies
        {
            get
            {
                return _currencies;
            }
        } 

        protected void Application_Start(object sender, EventArgs e)
        {
            RBKService.DailyInfo di = new RBKService.DailyInfo();
            DataSet courseDataSet = di.GetCursOnDate(DateTime.Today);
            DataSet currencyDataSet = di.EnumValutes(false);
            foreach (var element in currencyDataSet.Tables[0].AsEnumerable().Select(x=>x.Field<int?>("VnumCode")))
            {
                if (element.HasValue)
                {
                    var row =
                        courseDataSet.Tables[0].AsEnumerable().FirstOrDefault(x => x.Field<int>("Vcode") == element.Value);
                    if (row != null)
                    {
                        _currencies.Add(row.Field<string>("Vname"), row.Field<decimal>("Vcurs").ToString());
                    }
                }
            }

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}