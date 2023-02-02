$(document).ready(function () {
    getCategories();
});

function getCategories() {
    var tbody = document.getElementById('categories')
    tbody.innerHTML = "";
    $.get("/Admin/Category/GetCategories", function (data) {
        $.each(data, function (index, value) {
            $("#categories").append(`<tr class="gradeX">
                <td>${value.categoryId}</td>
                <td>${value.categoryName}</td>
                <td>
                     <a href="/Admin/Category/ChangeStatus/${value.categoryId}" class="btn btn-secondary" id="ChangeBtn"
                     onclick="return confirm('Kategori durumunu değiştirmek istedğinize emin misiniz?');">
                      ${value.status == true ? "Aktif" : "Pasif"}
                      </a>
                </td>
                <td>
                  <div class="btn-group">
                      <a href="/Admin/Category/UpdateCategory/${value.categoryId}" class="btn btn-warning">Update</a>
                      <a href="/Admin/Category/DeleteCategory/${value.categoryId}" class="btn btn-danger">Delete</a>
                  </div>
                </td>
             </tr>`);
        });
    });
}