$(document).ready(function () {
    GetEmployees()
})

function GetEmployees() {
    debugger
    $.ajax({
        url: "/Ajax/EmployeeList",
        type: "Get",
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = "";
            $.each(result, function (index, item) {
                object += "<tr>";
                object += "<td>"+ item.id +"</td>";
                object += "<td>" + item.Name +"</td>";
                object += "<td>" + item.State +"</td>";
                object += "<td>" + item.City +"</td>";
                object += "<td>" + item.Salary +"</td>"; 
                object += "</tr>";
            });
            $("#table_data").html(object);
        },
        error: function () {
            alert('Data not getted')
        }
    })
}

function AddEmployee() {
    debugger
    var objData = {
        Name: $("#Name").val(),
        State: $("#State").val(),
        City: $("#City").val(),
        Salary: $("#Salary").val()
    }
    $.ajax({
        url: "/Ajax/AddEmployee",
        type: "post",
        data: objData,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert('Data saved ')
            clearText()
            GetEmployees()
            hideModal()
        },
        error: function () { }
    });

    function hideModal() {
        $("#EmployeModal").modal('hide');
    }

    function clearText() {
            $("#Name").val(''),
            $("#State").val(''),
            $("#City").val(''),
            $("#Salary").val('')
    }
}

$("#AddEmployee").click(function () {
    $("#EmployeModal").modal('show');
})
$("#Modal_close").click(function () {
    $("#EmployeModal").modal('hide');
})
$("#CrossClose").click(function () {
    $("#EmployeModal").modal('hide');
})
