var dataTable;

$(document).ready(function () {
    //loadDataTable();
    BindDataTable();
});

var BindDataTable = function (response) {
    $("#tblData").DataTable({
        "processing": true,
        "bServerSide": true,
        "sAjaxSource": "/Staff/Student/GetRecords",
        "fnServerData": function (sSource, aoData, fnCallback) {
            $.ajax({
                type: "Get",
                data: aoData,
                url: sSource,
                success: fnCallback
            });
        },
        "columns": [
            { "data": "id" },
            { "data": "matNumber" },
            { "data": "regNumber" },
            { "data": "fullName" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="text-center">
                                <a href="/Staff/Student/InsertResults/${data}" class="btn bg-success text-white rounded" style="cursor: pointer">
                                    <i class="far fa-edit"></i>
                                </a>
                            </div>
                            `;
                }, "width": "10%"
            }
        ],
        "language": {
            "emptyTable": "No students found",
            "info": "Showing page _PAGE_ of _PAGES_"
        }
    });
}

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "processing": true,
        "ajax": {
            "url": "/Staff/Student/GetAll"
        },
        "columns": [
            { "data": "id" },
            { "data": "matNumber" },
            { "data": "regNumber" },
            { "data": "fullName" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="text-center">
                                <a href="/Staff/Student/InsertResults/${data}" class="btn bg-success text-white rounded" style="cursor: pointer">
                                    <i class="far fa-edit"></i>
                                </a>
                            </div>
                            `;
                }, "width": "10%"
            }
        ],
        "language": {
            "emptyTable": "No records found"
        },
        "width": "100%"
    });
}