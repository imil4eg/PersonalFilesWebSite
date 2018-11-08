// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var loadFile = function (event) {
    var reader = new FileReader();
    reader.onload = function () {
        var output = document.getElementById('profileImage');
        output.src = reader.result;
    };
    reader.readAsDataURL(event.target.files[0]);
};

var loadEducationFile = function (event) {
    var reader = new FileReader();
    reader.onload = function () {
        var output = document.getElementById('educationImage');
        output.src = reader.result;
    };
    reader.readAsDataURL(event.target.files[0]);
};

var imageResize = function (sender) {
    var src = $(sender).attr('src');
    $('<div>').css({
        background: 'RGBA(0,0,0,.5) url(' + src + ') no-repeat center',
        backgroundSize: 'contain',
        width: '100%', height: '100%',
        position: 'fixed',
        zIndex: '10000',
        top: '0', left: '0',
        cursor: 'zoom-out'
    }).click(function () {
        $(this).remove();
    }).appendTo('body');

    sender.style.width = (thisWidth - 10) + 'px';

    setTimeout(function () {
        sender.style.width = (thisWidth + 10) + 'px';
    }, 500);
};

$(function () {
    $('.datepicker-inline').datepicker({
        language: 'ru',
        format: 'dd-mm-yyyy'
    });
});

