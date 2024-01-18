

new DataTable('#tblData');

$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'prjName', "width": "15%" },
            { data: 'description', "width": "15%" },
            { data: 'image', "width": "15%" },
            { data: 'githubLink', "width": "15%" },
            { data: 'categoryId', "width": "15%" },
            {
                data: 'projectId',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/project/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/admin/project/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }
        ]
    });
}
