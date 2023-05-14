<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="gioithieu.aspx.cs" Inherits="LTWde6.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="public/gioithieu.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="maingt">
        <div class="menugt"> 
            <img class="anhgt" src="https://blog.topcv.vn/wp-content/uploads/2020/08/design-4.jpg" style="font-size: 10px;">
            <h6 class="kd" style="font-size: 20px; color: black;">KINH DOANH</h6>
            <h6 class="cn" style="font-size: 20px; color: black;">CÔNG NGHỆ</h6>
            <h6 class="ds" style="font-size: 20px; color: black;">ĐỜI SỐNG</h6>
            <h6 class="gt" style="font-size: 20px; color: black;">GIẢI TRÍ</h6>
            <h6 class="tt" style="font-size: 20px; color: black;">THỂ THAO</h6>

        </div>

        <div class="baivietgt">
            <p style="color: rgb(151, 155, 158);" class="writegt">Hiện nay, ngành công nghệ thông tin là một trong những ngành học được 
                chú trọng trong hệ thống đào tạo của trường Đại học Công nghệ thông tin cũng như các trường Đại học khác có đào tạo ngành 
                học này. Nó được xem là ngành đào tạo mũi nhọn hướng đến sự phát triển của công nghệ và khoa học kỹ thuật trong thời đại số
                hóa ngày nay.</p>

        </div>

        <div class="footergt">
            <div class="gcb">
                <div class="introduce">
                    <h4>Giới thiệu</h4>
                    <p>MM là công ty thiết kế website cao cấp có tuổi đời 8 năm trong ngành</p>
                    <p>Ngay từ buổi đầu thành lập đã chọn cho mình một phân khúc riêng, khác với hàng ngàn công ty dịch vụ website trên thị trường: phân khúc của sự hiệu quả</p>
                    <p>Những website phần mềm từ moha luôn được tư vấn, phát triển, tối ưu nhằm mang lại hiệu quả rõ rệt cho hoạt động kinh doanh của công nghiệp</p>

                </div>

                <div class="chuyen-muc">
                    <h4>Chuyên mục</h4>
                    <p>Đời sống</p>
                    <p>Kinh doanh</p>
                    <p>Giải trí</p>
                    <p>Công nghệ</p>
                    <p>Thể thao</p>
                    
                    <div class="box-toolgt">
                        <input class="stt" type="text" placeholder="Hãy chia sẻ điều gì đó..." size="65px">
                      </div>
                      <div class="dang-baigt">
                        <input class="post" type="submit" value="Đăng bài" >
                      </div>

                </div>

                <div class="ggmap">
                    <h4>Bản đồ</h4>
                    <div id="map" style="width:300px;height:300px;">
                      <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!
                      1d3723.8977453149246!2d105.83245751424809!3d21.036777085994046!
                      2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!
                      1s0x3135aba15ec15d17%3A0x620e85c2cfe14d4c!2zTMSDbmcgSOG7kyBDaMOtIE1pbmg!
                      5e0!3m2!1svi!2sus!4v1501056274257" width="450" height="300" frameborder="0" style="border:0" allowfullscreen></iframe>
                  </div>

                </div>

            </div>

        </div>

    </div>

    
</asp:Content>
