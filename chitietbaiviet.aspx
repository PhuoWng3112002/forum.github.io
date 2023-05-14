<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="chitietbaiviet.aspx.cs" Inherits="LTWde6.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
          <div class="main-content">
            <div class="row">
                
              
                <div class="leftcolumn">
                                <div class="general" style="margin-top:50px;">
                                    <div class="dieuhuong">
                                        <button type="button" onclick="back()" class="btnback"><i class="fa fa-arrow-left" style="font-size:24px; color:#003B70"></i></button>
                                       &nbsp;&nbsp;&nbsp;&nbsp;
                                        <a>QUAY LẠI</a>
                                    </div>
                                    <div class="before-cmt" id="innerbv" runat="server">
                                    </div>
                         
                                       <div class="cmt">
                                         <div class="activity-icons" >
                                           <i style="margin-left: 10px;" class="fa fa-thumbs-up">&nbsp;19k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class="fa fa-comment">&nbsp;1.5k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class="fa fa-eye">&nbsp;100k</i>&nbsp;&nbsp;&nbsp;&nbsp;
                                           <i class="fa fa-share">&nbsp;1k</i>
                                         </div>
                                       </div>
                                      <div class="after-cmt">
                                       <div class="list-cmt" id="innercmt" runat="server">
                                        
                                        
                                    </div>
                                           <div class="comment">
                                        <div class="box-circle">
                                            <img class="avt" src="./img/avatar.png" width="35px" alt="">
                                        </div>
                                               <form runat="server" onsubmit="return Xuly_Cmt()">
                                                 <input class="binhluan" name="txtCmt" id="txtCmt" type="text" placeholder="Hãy bình luận...">
                                                 <button value="true" type="submit" id="btnSend" name="btnSend" class="send">SEND</button>

                                               </form>
                                       
                                       </div>
                                       
                         
                                    </div>
                                </div>


                        
                    </div>
                        <%--<div id="Gioithieu" class="noidungtab">
                            <p>Trang được lập ra để cùng chia sẻ những kiến thức bổ ích. Mọi người cùng học hỏi, cùng phát triển.</p>

                        </div>--%>


                    
              <div class="rightcolumn">
                <div class="right1">
                  <div class="right-title"><p>_____Quan tâm nhiều nhất_____</p></div>
                  <div id="rightcontent" class="listcd" runat="server"></div>
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
    <script>
        function back() {
            history.back();
        }
    </script>
  
</asp:Content>
