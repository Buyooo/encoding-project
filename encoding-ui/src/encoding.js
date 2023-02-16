import * as signalR from '@microsoft/signalr';

window.addEventListener("load", () => {
    //Disable the send button until connection is established.
    document.getElementById("encode-button").disabled = true;

    let connection = new signalR.HubConnectionBuilder()
        .withUrl("http://localhost:5204/encodingHub")
        .build();

    connection.on("send", data => {
        console.log(data);
    });

    connection.on("ReceiveMessage", function (message) {
        document.getElementById("output-encoding").value = message;
    });

    connection.start().then(function () {
        document.getElementById("encode-button").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById("encode-button").addEventListener("click", function (event) {
        var encodeString = document.getElementById("input-encoding").value;
        connection.invoke("SendMessage", encodeString).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });
});

