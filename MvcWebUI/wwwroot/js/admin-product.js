$(document).ready(function () {
    getProducts();
});

function getProducts() {
    var tbody = document.getElementById('products')
    tbody.innerHTML = "";
    $.get("/Admin/Product/GetProducts", function (data) {
        $.each(data, function (index, value) {
            $("#products").append(`
                       <tr class="gradeX">
                           <td>${value.productId}</td>
                           <td>${value.productName}</td>
                           <td>${value.categoryId}</td>
                           <td>${value.unitPrice}</td>
                           <td>${value.unitsInStock}</td>
                           <td>
                               <a href="/Admin/Product/ChangeStatus/${value.productId}" class="btn btn-secondary" id="ChangeBtn"
                                   onclick="return confirm('Ürün durumunu değiştirmek istedğinize emin misiniz?');">
                                   ${value.status == true ? "Aktif" : "Pasif"}
                               </a>
                           </td>
                           <td>
                               <div class="btn-group">
                                   <a href="/Admin/Product/UpdateProduct/${value.productId}" class="btn btn-warning">Update</a>
                                   <a href="/Admin/Product/DeleteProduct/${value.productId}" class="btn btn-danger">Delete</a>
                               </div>
                           </td>
                       </tr>
            `);
        });
    });
}
