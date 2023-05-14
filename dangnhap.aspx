<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="LTWde6.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" onsubmit="return xulydulieu()">
<div class="containerlogin">
    <div class="box-dangnhap ">
            <div class="box-form " >
                <center><h1><b>Đăng Nhập</b></h1></center>
                <!-- <form method="post" id="form_login" onsubmit="return false"> -->
                    <div class="box-taikhoan">
                        <label for="" class="">Tài khoản</label>
                        <div class="" >
                            <input type="text" class="input" id="txtEmail" placeholder="Email" name="txtEmail"><br />
                        </div>
                    </div>
                            <span style="color: red;" id="email_loi"></span>
                    <div class="box-taikhoan">
                        <label for="" class="">Mật khẩu</label>
                        <div class="" >
                            <input type="password" class="input" id="txtPass" placeholder="Password" name="txtPass"><br />
                        </div>
                    </div>
                            <span style="color: red;" id="pass_loi"></span>
                    <div class="box-taikhoan" style="padding: 0; padding-left: 15px;">
                        <label for="" class=""></label>
                        <div class="" >
                            <input type="checkbox" class="input-checkbox" onchange="showpass()" name="" id="ckbHienMK">
                        <label for="ckbHienMK">Hiện mật khẩu</label>
                        </div>
                    </div>

                     <span style="color: red;" id="loi" runat="server"></span>

                    <center class="btnLogin">
                        <button type="submit" value="true" name="btnLogin" id="btnLogin"  >Đăng nhập</button>
                    </center>
                    <center>
                        <label><a href="#" style="color:blue">Quên mật khẩu ?</a></label>
                    </center>
                    <center><label>Chưa có tài khoản đăng ký tại<a href="dangky.aspx" style="color: blue"> đây !</a></label></center>

                <!-- </form> -->
            </div>

        
    </div>
    <script src="public/dangnhap.js"></script>
</div>
</form>
</asp:Content>
