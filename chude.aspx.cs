using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace LTWde6
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tenchude=Request.QueryString["id"];
            string listcde = "";
            string quantam = "";
            string thanhdieuhuong = "";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml/congdong.xml"));
            XmlNodeList listcd = xdoc.GetElementsByTagName("congdong");
            int count = 0;
            foreach (XmlNode cd in listcd)
            {
                string id = cd.ChildNodes[0].InnerText;
                string Url_img = cd.ChildNodes[1].InnerText;
                string tencongdong = cd.ChildNodes[2].InnerText;
                string chude = cd.ChildNodes[3].InnerText;
                string sothanhvien = cd.ChildNodes[4].InnerText;
                string sobaiviet = cd.ChildNodes[5].InnerText;
                string idchude = cd.ChildNodes[6].InnerText;
                if (tenchude == idchude)
                {
                    thanhdieuhuong = @"<a href='trangchu.aspx'> TRANG CHỦ </a> <i class='fa fa-angle-double-right'></i> <a>" + chude + "</a>";

                    listcde += @"<div class='congdong'>
                            <div class='card'>
                            <div class='STT'>" + (count = count + 1) + @"</div>
                            <div class='image' >
                                <img src = '" + Url_img + @"' width='50%'>
                            </div>
                            <div class='tieude'>
                                <a href='trangcongdong.aspx?id="+id+@"' class='tencd'>" + tencongdong + @"</a>
                                <div class='chude'>" + chude + @"</div>
                                <p>" + sothanhvien + @" Thành viên   " + sobaiviet + @" Bài viết</p>
                            </div>
                            <div class='quantam'>
                                <button class='thamgia'><a>Quan tâm</a></button>
                            </div>
                          </div>
                         </div>";
           
            
                
                
                    quantam += @"<div class='right-congdong'>
                        <div class='image'>
                          <img src ='" + Url_img + @"'width='80%'>
                        </div>
                        <div class='tieude'>
                          <h4>" + tencongdong + @"</h4>
                          <p>" + sothanhvien + @" Thành viên   " + sobaiviet + @" Bài viết</p>
                        </div>
                        </div>";

                    XmlDocument pbien = new XmlDocument();
                    pbien.Load(Server.MapPath("xml/baiviet.xml"));
                    XmlNodeList listpb = pbien.GetElementsByTagName("baiviet");

                    string phobien = "";

                    int countpb = 0;
                    foreach (XmlNode pb in listpb)
                    {
                        if (countpb < 5)
                        {
                            countpb++;
                        }
                        else { break; }

                        string idpb = pb.ChildNodes[0].InnerText;
                        string tenbv = pb.ChildNodes[5].InnerText;

                        phobien += @"<a href='chitietbaiviet.aspx?id=" + id + @"' style='text-decoration:none;
    color:#003B70;'><i class='fas fa-circle'></i>&nbsp;&nbsp;&nbsp;&nbsp;" + tenbv + @"</a><br/>";
                    }

                    listphobien.InnerHtml = phobien;
                }

                
            }
            listchude.InnerHtml = listcde;
            dieuhuong.InnerHtml = thanhdieuhuong;
            listqt.InnerHtml = quantam;


            

        }
    }
}
    
