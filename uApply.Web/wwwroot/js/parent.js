﻿var dataTable;

$(document).ready(() => {
    loadTableData();
});

var loadTableData = () => {

    dataTable = $("#parentTable").DataTable({
        "ajax": {
            "url": "/User/Parent/GetAll"
        },
        "columns": [
            { "data": "fullNames", "width": "15%" },
            { "data": "surname", "width": "15%" },
            { "data": "idNumber", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "Nationality", "width": "15%" },
            {
                "data": "id",
                "render": (data) => {
                    return `
                            <div class="d-flex justify-content-center align-items-center">
                                <a class="btn btn-info m-2" href="/Admin/Product/Upsert/${data}">Edit</a>
                                <a class="btn btn-danger m-2" onclick=Delete("/admin/product/delete/${data}")>Delete</a>
                            </div
                        `;
                }
            }
        ]
    })
}

var Delete = (url) => {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: (data) => {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message)
                    }
                }
            });
        }
    });
}