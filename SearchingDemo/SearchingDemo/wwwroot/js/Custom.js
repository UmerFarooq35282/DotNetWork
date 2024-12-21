$(document).ready(() => {
    $("#ModalBtn").click(() => {
        ShowModel()
    })
    $("#CloseBtn").click(() => {
        HideModel()
    })
    $("#SaveBtn").click(() => {
        SaveCategory()
    })
})

function ShowModel() {
    $("#EmployeeModal").modal('show');
}
function HideModel() {
    $("#EmployeeModal").modal('hide');
}

function SaveCategory() {
    
    var obj = new Object()

    obj.CategoryId = $("#CategoryId").val()
    obj.CategoryName = $("#CategoryName").val()

    $.ajax({
        url: "/Categories/AddCategory",
        type: "post",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=utf-8;',
        data: obj,
        success: function (data, status, xhr) {
            alert('Category Saved')
            HideModel()
        },
        error: function () {

        }
    })
}