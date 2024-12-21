$(document).ready(() => {
    getAllEmployes()
    $("#AddEmp").click(() => {
        $("#exampleModalCenter").modal('show')
    })
    $("#closeBtn").click(() => {
        hideModal()
    })

    $("#saveBtn").click(() => {
        var Id = $('#txtId').val()
        var Name = $('#txtName').val()
        var City = $('#txtCity').val()
        var Country = $('#txtCountry').val()
        var Phone = $('#txtPhone').val()
        var Image = $('#txtImage').val()

        var obj = new Object()
        obj.EmployeId = Id
        obj.EmployeName = Name
        obj.EmpCity = City
        obj.EmpCountry = Country
        obj.EmpPhone = Phone
        obj.EmpImage = Image

        $.ajax({
            url: "Employees/CreateEmp",
            type: "POST",
            contentType: "application/x-www-form-urlencoded;charset=utf-8;",
            data: obj,
            success: function (data)
            {
                hideModal()
                getAllEmployes()
            },
            error: function (error) {
                alert(`Error : ${error}`)
            }
        })
    })

});

function hideModal() {
    $("#exampleModalCenter").modal('hide')
}

function getAllEmployes() {
    
    $.ajax({
        url: "/Employees/GetEmployees",
        method: 'GET',
        dataType: 'json',
        contentType:'application/json;charset=utf-8;',
        success: function (data)
        {
            var obj = "";
            $.each(data, (index, item) => {
                obj += `
                    <tr>
                        <td>${item.employeId}</td>
                        <td>${item.employeName}</td>
                        <td>${item.empCity}</td>
                        <td>${item.empCountry}</td>
                        <td>${item.empPhone}</td>
                        <td>${item.empImage}</td>
                        <td>
                        <a href="#" class="btn btn-success">Edit</a> ||
                        <a href="#" class="btn btn-danger" onclick='deleteEmployee(${item.employeId})'>Delete</a>
                        </td>
                    </tr>
                `
                
            });
            $("#Load-Data").html(obj);
            
        },
        error: function (error) {
            console.log(`Error In Getting Data ${error}`);
        },
    })
    
}

function deleteEmployee(id) {
    $.ajax({
        url: "/Employees/DeleteEmployees/" + id,
        success: () =>
        {
            alert('Data deleted')
            getAllEmployes()
        }
    })
}


    
