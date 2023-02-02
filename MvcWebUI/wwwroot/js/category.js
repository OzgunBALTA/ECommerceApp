$(document).ready(function () {
    getCategories();
});

function getCategories() {
    $.get("/getcategories", function (data) {
        $.each(data, function (index, value) {
            $("#side-menu").append(`<li><a href='#' id="category" onclick = "fun(${value.categoryId})" ><i class="fa fa-desktop"></i><span class="nav-label">${value.categoryName}</span></a></li>`);
        });
    });
}