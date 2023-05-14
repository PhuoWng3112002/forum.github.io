<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="chude.aspx.cs" Inherits="LTWde6.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="public/chude.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
          <div class="main-content">
            <div class="row">
              <div class="leftcolumn">
                  <div class="thanhdieuhuong" id="dieuhuong" runat="server">
                      <%--<a href="trangchu.aspx">Trang chủ</a> >>
                      <a >ten</a>--%> </div>
                <div class="xephangcongdong"><p>__XẾP HẠNG CỘNG ĐỒNG__</p></div>
                <div id="listchude" class="listgt" runat="server"></div>
                  <!--giải phân cách-->
                <button class="xemthem">
                    <p>XEM THÊM</p>
                </button>
              </div>
              <div class="rightcolumn">
                <div class="right1">
                  <div class="right-title"><p>_____Quan tâm nhiều nhất_____</p></div>
                  <div id="listqt" class="listgt" runat="server"></div>
                  </div>
                  <div class="right2">
                    <div class="right-title"><p>_____Bài viết phổ biến_____<p></div>
                    <div class="right-congdong">
                        <div class="phobien" id="listphobien" runat="server">
                            <p><i class="fas fa-circle"></i>&nbsp;&nbsp;&nbsp;&nbsp;Cổ phiếu nhóm FLC bị bán tháo</p>
                        </div>
                    </div> 
                  </div>
              </div>    
            </div>
          </div>
  </div>
</asp:Content>
