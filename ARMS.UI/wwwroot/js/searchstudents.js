var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Staff/Student/GetAll"
        },
        "columns": [
            { "data": "studentId" },
            { "data": "matNumber" },
            { "data": "lastName" },
            { "data": "firstName" },
            { "data": "middleName" },
            {
                "data": "studentId",
                "render": function (data) {
                    return `
                            <div class="text-center">
                                <a href="/Staff/Student/Insert/${data}" class="btn bg-success text-white rounded" style="cursor: pointer">
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