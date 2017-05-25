$(document).ready(function () {
    $("#RegisterForm").submit(function () {
        var form = $(this);
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        var data = $(this).serialize();
        console.log(data);
        $.ajax({
            url: "/Account/Register",
            type: 'POST',
            data: data,
            success: function (result) {
                if (result == "1") {
                    location.reload();
                }
                else {
                    $('.error-message').append(result).css("color", "red");
                }
            }
        });
        return false;

    });
    $("#LoginForm").submit(function () {
        var form = $(this);
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        var data = $(this).serialize();
        console.log(data);
        $.ajax({
            url: "/Account/Login",
            type: 'POST',
            data: data,
            success: function (result) {
                if (result == "1") {
                    location.reload();
                }
                else {
                    $('.error-message').append(result).css("color", "red");
                }
            }
        });
        return false;

    });
    $("#addThred").submit(function () {
        var form = $(this);  
        var data = $(this).serialize();
        $.ajax({
            url: "/Home/AddThread",
            type: 'POST',
            data: data,
            success: function (result) {
                if (result == "1") {
                    location.reload();
                }
                else {
                    $('.error-message').append(result).css("color", "red");
                }
            }
        });
        return false;
    })

});