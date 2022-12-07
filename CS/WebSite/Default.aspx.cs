using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }


    protected void grid_DataBound(object sender, EventArgs e) {
        if (!IsPostBack || !IsCallback) {
            ASPxGridView grid = sender as ASPxGridView;
            for (int i = 0; i < grid.VisibleRowCount; i++) {
                 if (grid.IsGroupRow(i) && (grid.GetRowLevel(i) == 0)) {
                    grid.ExpandRow(i);

                }
            }
        }
    }
}

