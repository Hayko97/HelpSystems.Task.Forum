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