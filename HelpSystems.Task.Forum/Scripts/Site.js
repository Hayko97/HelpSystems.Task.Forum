
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
    });
    $("#addPost").submit(function () {
        var form = $(this);
        var data = $(this).serialize();
        $.ajax({
            url: "/Home/AddPost",
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
    $(".editPost").submit(function () {
        var form = $(this);
        var data = $(this).serialize();
        $.ajax({
            url: "/Home/EditPost",
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

});
function editPost(object)
{
    debugger;
    var postId = $(object).data("id");
    var data = $("#edit" + postId).serialize();
    
    $.ajax({
        url: "/Home/EditPost",
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
}
function deletePost(object) {
    debugger;
    var postId = $(object).data("id");
    var data = $("#delete" + postId).serialize();

    $.ajax({
        url: "/Home/DeletePost",
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
}

function closeOrOpenThread(object) {
    debugger;
    var id = $(object).data("id");
    

    $.ajax({
        url: "/Home/CloseOrOpen",
        type: 'POST',
        data: {Id:id},
        success: function (result) {
            if (result == "1") {
                location.reload();
            }
            else {
                $('.error-message').append(result).css("color", "red");
            }
        }
    });
}