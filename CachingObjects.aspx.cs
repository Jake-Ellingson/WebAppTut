using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace WebAppTut
{
    public partial class CachingObjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList datestamps;

            if (Cache["datestamps"] == null)
            {
                datestamps = new ArrayList();
                datestamps.Add(DateTime.Now);
                datestamps.Add(DateTime.Now);
                datestamps.Add(DateTime.Now);

                Cache.Add("datestamps", datestamps, null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 60), System.Web.Caching.CacheItemPriority.Default, null);
            }
            else
                datestamps = (ArrayList)Cache["datestamps"];

            foreach (DateTime dt in datestamps)
                Response.Write(dt.ToString() + "<br />");
        }
    }
}