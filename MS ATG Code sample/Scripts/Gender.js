// i wrote this method as string to be inclusive to people who identify as non gender binary.

function vote(param) {
    var targeturl = location.origin + "/home/Vote";
    var result = $.ajax({
        url: targeturl,
        method: "POST",
        data: " { \"gender\" : \"" + param + "\" }",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        Error: function (response)
        { alert(Error); }
    });
    // in a real work item i'd use a call back instead of a postback, but as this is a demo its kinda overkill
    window.location.reload(false);
}