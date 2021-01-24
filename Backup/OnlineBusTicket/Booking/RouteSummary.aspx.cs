using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataTransmission;

namespace OnlineBusTicket.Booking
{
    public partial class RouteSummary : System.Web.UI.Page
    {
        DataSet _RouteSet = new DataSet();
        pbooking _pbook = new pbooking();

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExpirePageCache();
                if (Session["_BUSID"] != null)
                {
                    object[] obj = new object[1];
                    obj[0] = Convert.ToInt32(Session["_BUSID"]);
                    _RouteSet = _pbook.GetRouteDetails(obj);
                    if (_RouteSet != null)
                    {
                        if (_RouteSet.Tables[0].Rows.Count > 0)
                        {
                            grd_routeDetails.DataSource = _RouteSet.Tables[0];
                            grd_routeDetails.DataBind();
                            Session.Remove("_BUSID");
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                    }


                }
            }
        }
        #endregion

        private void ExpirePageCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now - new TimeSpan(1, 0, 0));
            Response.Cache.SetLastModified(DateTime.Now);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
        }
    }
}