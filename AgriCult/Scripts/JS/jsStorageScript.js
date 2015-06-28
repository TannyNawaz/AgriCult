$(function () {

    var AgriIndex = 0;

    $("#save").click(function () {
            if (Modernizr.localstorage) {

            saveToLocal();

            if (isOnLine()) {
                saveToServer();
            }
        }
        else {
            alert("AgriCult requires local storage.");
        }
    });

    function isOnLine() {
        return navigator.onLine;
    }

    function getModel(index) {
        var model = {
            Name: "",
            Comment: "",
            IsDirty: false,
            Key: "",
            ID: ""
        };

        if (localStorage[index] != null) {
            model = JSON.parse(localStorage[index]);
        }
        model.Key = index;
        return model;
    }

    function saveToLocal() {
        var model = getModel(AgriIndex);
        model.Name = $("#name").val();
        model.Comment = $("#Comment").val();
        model.IsDirty = true;
        localStorage.setItem(AgriIndex,
            JSON.stringify(model));
        logMessage("'" + model.Name + "' saved locally.");
    }

    function saveToServer() {
        for (var i = 0; i < localStorage.length; i++) {
            var model = getModel(i);
            if (model.IsDirty) {
                $.post("/agri/save", model,
                    function (data) {
                        var key = data.Key;
                        var m = getModel(key);
                        m.ID = data.ID;
                        m.IsDirty = false;
                        localStorage[key] =
                            JSON.stringify(m);
                        logMessage("'" +
                            m.Name + "' saved to server");
                    });
            }
        }
    }

    function logMessage(message) {
        $("#log").append("<li>" + message + "</li>");
    }

    function showCustomer() {
        var model = getModel(AgriIndex);
        if (model == null) {
            clearUI();
        }
        else {
            $("#name").val(model.Name);
            $("#Comment").val(model.Comment);
        }
    }

        $("#clearBtn").click(function () {
            $("#name, #Comment, #size, #location, #owner, #specializedIn").val("");
            $("#log").html("");
        });

    function reportOnlineStatus() {
        var status = $("#onlineStatus");
        var message = $("#statusMessage");

        if (isOnLine()) {
            status.text("Online - Connected");
            status.
                removeClass("offline").
                addClass("online");
            message.css('display', 'none');
        }
        else {
            status.text("Offline - Disconnected");
            status.
                removeClass("online").
                addClass("offline");
            message.css('display', '');
        }
    }

    window.applicationCache.onupdateready = function (e) {
        applicationCache.swapCache();
        window.location.reload();
    }

    window.addEventListener("online", function (e) {
        reportOnlineStatus();
        saveToServer();
    }, true);

    window.addEventListener("offline", function (e) {
        reportOnlineStatus();
    }, true);

    if (isOnLine()) {
        saveToServer();
    }
    showCustomer();
    reportOnlineStatus();

});