using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using LTWde6.Model;
using System.Data;

namespace LTWde6
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             var idcd = Request.QueryString["id"];
             string bviet = "";
                XmlDocument bv = new XmlDocument();
                bv.Load(Server.MapPath("xml/baiviet.xml"));
            XmlNodeList listbv = bv.GetElementsByTagName("baiviet");

               
                foreach (XmlNode baiviet in listbv)
                {

                    string idbv = baiviet.ChildNodes[0].InnerText;
                    string congdong = baiviet.ChildNodes[1].InnerText;
                    string idcongdong = baiviet.ChildNodes[2].InnerText;
                    
                    string user = baiviet.ChildNodes[3].InnerText;
                    string time = baiviet.ChildNodes[4].InnerText;
                    string tieude = baiviet.ChildNodes[5].InnerText;
                    string noidung = baiviet.ChildNodes[6].InnerText;

                    if (idcd == idcongdong)
                    {
                        bviet += @"

                                        <div class='anh-ten'>
                                          <div class='box-circle'>
                                            <img class='avt' src='./img/avatar.png' width='35px' alt=''>
                                          </div>
                             
                                          <div class='ten'>
                                            <a class='hoten'>" + user + @"</a>
                                            <br> <p class='gio'>" + time + @"</p>
                             
                                          </div>
                             
                                        </div>
                             
                                        
                                        <div class='write'>
                             
                                         <div class='write-1'  style = 'display:-webkit-box;
                                            -webkit-box-orient:vertical;
                                            -webkit-line-clamp:10;
                                            overflow:hidden;
                                            margin-top:20px;'>
                                           <h3 class='title-bv'>" + tieude + @"</h3>
                                          <p style='margin-top:20px;'>" + noidung + @"
                                         </p>
                                
                                        <a href = 'chitietbaiviet.aspx?id=" + idbv + @"' style='text-decoration: none; font-weight:bold; color: #003B70;'>Chi tiết</a>
                                           
                                    </div>
<a href = 'chitietbaiviet.aspx?id=" + idbv + @"' style='text-decoration: none; font-weight:bold; color: #003B70;'>Chi tiết</a>
                                        </div>
                                    
                         
                                       <div class='cmt'>
                                         <div class='activity-icons' >
                                           <i style = 'margin-left: 10px;' class='fa fa-thumbs-up'>&nbsp;19k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class='fa fa-comment'>&nbsp;1.5k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class='fa fa-eye'>&nbsp;100k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class='fa fa-share'>&nbsp;1k</i>
                                         </div>
                               
                                </div>";

                    string quantam = "";

                    XmlDocument quan = new XmlDocument();
                    quan.Load(Server.MapPath("xml/congdong.xml"));
                    XmlNodeList listcd = quan.GetElementsByTagName("congdong");

                    int countqt = 0;
                    foreach (XmlNode cd in listcd)
                    {
                        if (countqt < 5)
                        {
                            countqt++;
                        }
                        else { break; }

                        string id = cd.ChildNodes[0].InnerText;
                        string Url_img = cd.ChildNodes[1].InnerText;
                        string tencongdong = cd.ChildNodes[2].InnerText;
                        string tenchude = cd.ChildNodes[3].InnerText;
                        string sothanhvien = cd.ChildNodes[4].InnerText;
                        string sobaiviet = cd.ChildNodes[5].InnerText;
                        string idchude = cd.ChildNodes[6].InnerText;

                        quantam += @"<div class='right-congdong'>
                        <div class='image'>
                          <img src ='" + Url_img + @"'width='80%'>
                        </div>
                        <div class='tieude'>
                          <h4>" + tencongdong + @"</h4>
                          <p>" + sothanhvien + @" Thành viên   " + sobaiviet + @" Bài viết</p>
                        </div>
                        </div>";
                    }
                    rightcontent.InnerHtml = quantam;

                }
                }
            
                    

            listbaiviet.InnerHtml = bviet;

            /***********************BV pho bien **************/
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

                string id = pb.ChildNodes[0].InnerText;
                string tenbv = pb.ChildNodes[5].InnerText;

                phobien += @"<a href='chitietbaiviet.aspx?id=" + id + @"' style='text-decoration:none;
    color:#003B70;'><i class='fas fa-circle'></i>&nbsp;&nbsp;&nbsp;&nbsp;" + tenbv + @"</a><br/>";
            }

            listphobien.InnerHtml = phobien;
        }
    }
}