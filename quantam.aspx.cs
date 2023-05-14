using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using LTWde6.Model;
namespace LTWde6
{
    public partial class quantam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            acc account = (acc)Session["acc"];
            if (Session["quantam"] != null || account.Cart != null)
            {
                DataTable cart = (account.Hoten == null) ? (DataTable)Session["giohang"] : account.Cart;
                string sl = cart.Rows.Count.ToString();
                string output = "";
                foreach (DataRow row in cart.Rows)
                {
                    output += @"<div class='right-congdong'>
                        <div class='image'>
                          <img src ='" + row["image"].ToString() + @"'width='80%'>
                        </div>
                        <div class='tieude'>
                          <h4>" + row["tencongdong"].ToString() + @"</h4>
                          <p>111 Thành viên  222  Bài viết</p>
                        </div>
                         <div class='quantam'>
                          <button type='button' onclick='xoa(" + row["id"].ToString() + @")' title='xoa' style='background: red; color: white;' class='remove-product'><i class='far fa-trash-alt'></i></button>
                        </div>";
                }

                quantamcart.InnerHtml = output;

            }
        }



    }
}
