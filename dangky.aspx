<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="LTWde6.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <form id="form1" name="form1" runat="server" onsubmit="return xulydulieu_dangky()">
<div class="containerlogin">
    <div class="box-dangnhap ">
            <div class="box-form " >
                <center><h1><b>Đăng Ký</b></h1></center>

                <div class="box-taikhoan">
                    <label for="" class="">Tài khoản</label>
                    <div class="" >
                        
                        <input type="text" class="input" id="txtEmail" placeholder="Email" name="txtEmail"><br />
                    </div>
                </div>
                        <span style="color: red;" id="email_loi"></span>
                        <span style="color: red;" id="email_format"></span>
                <div class="box-taikhoan">
                    <label for="" class="">Mật khẩu</label>
                    <div class="" >
                        <input type="password" class="input" id="txtPass" placeholder="Password" name="txtPass"><br />
                        <div id="loidk"></div>
                    </div>
                </div>
                            <span style="color: red;" id="pass_loi"></span>

                    <div class="box-taikhoan">
                        <label for="" class="">Nhập lại mật khẩu</label>
                        <div class="" >
                            <input type="password" class="input" id="txtRePass" placeholder="RePass" name="txtRePass"><br />
                        </div>
                    </div>
                            <span style="color: red;" id="repass_loi""></span>

                    <div class="box-taikhoan" style="padding: 0; padding-left: 15px;">
                        <label for="" class=""></label>
                        <div class="" >
                            <input type="checkbox" class="input-checkbox" onchange="showpass_dangky()" name="" id="ckbHienMK">
                        <label for="ckbHienMK">Hiện mật khẩu</label>
                        </div>
                    </div>
                            <span style="color: red;" id="Span1" runat="server"></span>

                    <center class="btnLogin">
                        <button type="submit" value="true" name="btnRegistration" id="btnRegistration">Đăng Ký</button>
                    </center>
                    <center><label>Đã có tài khoản đăng nhập tại<a href="dangnhap.aspx" style="color: blue"> đây !</a></label></center>


            </div>

        
    </div>
   
    <script src="public/dangnhap.js"></script>
</div>
</form>
</asp:Content>
<%--pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" title="Email must be right format form" id="txtEmail" placeholder="Email" name="txtEmail"><br />
                    </div>--%>