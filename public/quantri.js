function checktrongqt() {
    const loiqt = document.querySelector("#loi");
    const idcde = document.querySelector("#idcde").value;
    const chude = document.querySelector("#chude").value;
    const imgcde = document.querySelector("#imgcde").value;

    var checkqt = true;
    loiqt.innerHTML = "";
    if (idcde == "") {
        loiqt.innerHTML += "ID không được để trống";
        checkqt = false;
    }
    if (chude == "") {
        loiqt.innerHTML += "Tên chủ đề không được để trống";
        checkqt = false;

    }
    if (imgcde == "") {
        loiqt.innerHTML += "Ảnh không được để trống";
        checkqt = false;

    }
    
}