using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Data;
using System.Xml.Linq;
using LTWde6.Model;

namespace LTWde6
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            string qtbv = "";
            XmlDocument xdoccd = new XmlDocument();
            xdoccd.Load(Server.MapPath("xml/baiviet.xml"));
            XmlNodeList listcd = xdoccd.GetElementsByTagName("baiviet");

            int count = 0;
            foreach (XmlNode cd in listcd)
            {
               
                string idbv = cd.ChildNodes[0].InnerText;
                string congdong = cd.ChildNodes[1].InnerText;
                string idcd = cd.ChildNodes[2].InnerText;
                string user = cd.ChildNodes[3].InnerText;
                string time = cd.ChildNodes[4].InnerText;
                string tieude = cd.ChildNodes[5].InnerText;
                string noidung = cd.ChildNodes[6].InnerText;

                qtbv+=@"<tr>
              <td>"+(count=count+1)+@"</td>
              <td>" + congdong + @"</td>
              <td>" + tieude+ @"</td>
               <td style ='display:-webkit-box;
                                            -webkit-box-orient: vertical;
                                            -webkit-line-clamp: 3;
                                            overflow: hidden;text-align:left;'><a style='text-derection:none; color:#003B70;' href='chitietbaiviet.aspx?id="+idbv+@"'>Chi tiết</a><br/>" + noidung + @"</td>
                <td >" + time + @"</td>
                <td><button class='thaotacxoa'>Xóa</button></td>
            </tr>";
                

            }

            idquantribaiviet.InnerHtml = qtbv;

        }

    }
    
}