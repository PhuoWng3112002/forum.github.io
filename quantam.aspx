<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="quantam.aspx.cs" Inherits="LTWde6.quantam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
          <div class="main-content">
            <div class="row">
              <div class="leftcolumn">
                <div id="quantamcart" class="listquantam" runat="server"></div>
                  <!--giải phân cách-->
              </div>
              <div class="rightcolumn">
                <div class="right1">
                  <div class="right-title"><p>_____Quan tâm nhiều nhất_____</p></div>
                  <div id="rightcontent" class="listcd" runat="server"></div>
                  </div>
                  <div class="right2">
                    <div class="right-title"><p>_____Bài viết phổ biến_____<p></div>
                    <div class="right-congdong">
                        <div class="phobien">
                            <p><i class="fas fa-circle"></i>&nbsp;&nbsp;&nbsp;&nbsp;Cổ phiếu nhóm FLC bị bán tháo</p>
                        </div>
                    </div> 
                  </div>
              </div>    
            </div>
          </div>
  </div>
</asp:Content>
