// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ajaxInfo(id) {
    $.ajax({
        type: "GET",
        url: "/Home/GetShopInfo?shopId="+id,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            document.getElementById('info').innerHTML = response.responseText;
        },
        failure: function (response) {
            document.getElementById('info').innerHTML = response.responseText;
        },
        error: function (response) {
            document.getElementById('info').innerHTML = response.responseText;
        }
    });
}