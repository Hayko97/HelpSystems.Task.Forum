$(document).ready(function () {
 
});
function RemoveTopic(object) {

    var id = $(object).data("topic");
    var id1 = $(id);
    $.post("/Admin/TopicRemove", { id: id }, function (data) {
        if (data == "1")
            location.reload();


    });
};
function deleteUser(object) {
    debugger;
    var postId = $(object).data("id");
    

    $.ajax({
        url: "/Admin/DeleteUser",
        type: 'POST',
        data: {Id:postId},
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
function deleteThread(object) {
    debugger;
    var postId = $(object).data("id");


    $.ajax({
        url: "/Admin/DeleteThread",
        type: 'POST',
        data: { Id: postId },
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