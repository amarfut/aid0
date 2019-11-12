// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class UrlHelper {
    makePost(url, data) {
        $.ajax({
            url: url,
            type: 'POST',
            contentType: "application/json",
            data: JSON.stringify(data),
            success: (data) => {
               
            },
            error: (error) => {
               
            }
        });
    }
}