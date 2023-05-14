using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTWde6.Model;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace LTWde6
{
    public partial class XulyCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string image = "";
            //string tencongdong = "";
            //string chude = "";
            //string sothanhvien = "";
            //string sobaiviet = "";
            //var act = Request.QueryString["action"];
            //var idcongdong = Request.QueryString["id"];
            //Response.Write("<script> alert('" + act + "')</script>");
            //DataTable cart = new DataTable();
            //if (act == "them")
            //{
            //    XDocument xdoc =XDocument.Load( @"G:/LTWde6/LTWde6/xml/congdong.xml");
            //   //XmlNodeList listcd = xdoc.("congdong");
            //    var nodeList = xdoc.Descendants("listcongdong")
            //        .Where(cd => cd.Element("id").Value == idcongdong)
            //        .Elements()
            //        .Select(cd=>cd.Value).ToList();
                //XmlDocument xdoc = new XmlDocument();
                //xdoc.Load(Server.MapPath("xml/congdong.xml"));
                //var nodeList = from congdong in xdoc.Descendants("congdong")
                //               where (string)congdong.Element("id") == idcongdong
                //               select congdong;
               
               // foreach (var cdg in nodeList)
                //{
                   

                //}
            //    foreach (var cd in listcd)
            //    {
            //        idcongdong = cd.ChildNodes[0].InnerText;
            //        image = cd.ChildNodes[1].InnerText;
            //        tencongdong = cd.ChildNodes[2].InnerText;
            //        chude = cd.ChildNodes[3].InnerText;
            //        sothanhvien = cd.ChildNodes[4].InnerText;
            //        sobaiviet = cd.ChildNodes[5].InnerText;
            //        string idchude = cd.ChildNodes[6].InnerText;
                    
            //    }
            //    if (Session["giohang"] == null )
            //    {
            //        //chưa có giỏ hàng, tạo giỏ hàng 
            //        //cart.Columns.Add("idcongdong");
            //        cart.Columns.Add("image");
            //        cart.Columns.Add("tencongdong");
            //        //cart.Columns.Add("chude");
            //        //cart.Columns.Add("sothanhvien");
            //        //cart.Columns.Add("sobaiviet");
            //        cart.Rows.Add(image, tencongdong);
                   
            //    }
            //    else
            //    {
            //        //Lấy thông tin giỏ hàng từ Session["giohang"]
            //        //cart = (account.Hoten == null) ? (DataTable)Session["giohang"] : (DataTable)account.Cart;
            //        // kiem tra ton tai san pham
            //        int check = 0;
            //        foreach (DataRow dr in cart.Rows)
            //        {
            //            if (dr["id"].ToString() ==idcongdong)
            //            {
            //                dr["soluong"] = int.Parse(dr["soluong"].ToString()) + 1;
            //                check = 1;
            //                break;
            //            }
            //        }
            //        if (check == 0)
            //        {
            //            cart.Rows.Add(image, tencongdong);
            //        }
                    
            //    }
            //    //Response.Redirect("quantam.aspx");
            //    return;
            //}

        }
    }
}