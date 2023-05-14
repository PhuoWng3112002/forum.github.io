
    function openPage(pageName,elmnt) {
  var i, noidungtab, btntab;
    noidungtab = document.getElementsByClassName("noidungtab");
    for (i = 0; i < noidungtab.length; i++) {
        noidungtab[i].style.display = "none";
  }
    btntab = document.getElementsByClassName("btntab");
    for (i = 0; i < btntab.length; i++) {
        btntab[i].style.backgroundColor = "";
  }
    document.getElementById(pageName).style.display = "block";
  //elmnt.style.backgroundColor = color;
}

    // Get the element with id="defaultOpen" and click on it
    document.getElementById("defaultOpen").click();


    //*************************************//
    function dropdown_ft() {
        document.getElementById("ft-drop").classList.toggle("show");


function Xuly_Cmt() {
    trangthai = true;
    var txtCmt = document.getElementById("txtCmt").value;
    
    if (txtCmt == "") {
        alert("Comment không được bỏ trống");
        trangthai = false;
    } else {
        trangthai = true;
    }

    //return trangthai;
}
