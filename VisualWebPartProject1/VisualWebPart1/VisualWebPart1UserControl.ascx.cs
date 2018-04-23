using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace VisualWebPartProject1.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite("http://spdevapp"))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    SPList list = web.Lists.TryGetList("Employee");
                    SPListItemCollection collection = list.Items;
                    gvList.DataSource = collection.GetDataTable();
                    gvList.DataBind();
                }
            }
        }
    }
}
