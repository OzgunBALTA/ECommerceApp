$(document).ready(function () {
    getProducts();
});

function fun(id) {
    var tbody = document.getElementById('products')
    tbody.innerHTML = "";
    const url = "/getproductsbycategoryid/"
    $.get(`${url}${id}`, function (data) {
        $.each(data, function (index, value) {
            $("#products").append(`
                       <tr>
                           <td>${value.productId}</td>
                           <td>${value.productName}</td>
                           <td>${value.unitPrice}</td>
                       </tr>
            `);
        });
    });
}

function getProducts() {
    var tbody = document.getElementById('products')
    tbody.innerHTML = "";
    $.get("/getallproducts", function (data) {
        $.each(data, function (index, value) {
            $("#products").append(`
                       <tr>
                           <td>${value.productId}</td>
                           <td>${value.productName}</td>
                           <td>${value.unitPrice}</td>
                       </tr>
            `);
        });
    });
}