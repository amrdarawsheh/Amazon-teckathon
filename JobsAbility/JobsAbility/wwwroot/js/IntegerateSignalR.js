var connection = new signalR.HubConnectionBuilder()
    .withUrl('/Chat')
    .build();

connection.on('receiveMessage', (r) => {
    console.log(r);
    addMessageToChat(r);
});

connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('sendMessage', message);
}