class Message {
    constructor(text, toId, fromId) {
        this.messageContent = text;
        this.toId = toId;
        this.fromId = fromId;
    }
}

// userName is declared in razor page.
const messagesQueue = [];

function AddMessageToDB() {

}

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() === "") return;
    AddMessageToDB();
    let message = new Message(text, toUserId, thisUserId);
    sendMessageToHub(message);
}
var sentTemplate = '<li class="sent"> <div> <div>Me</div> <img src="/img/avatarYou.png" alt="" /> <p>%@#^text%@#^</p> </div> </li>'
var replyTemplate = '<li class="replies"> <div class="float-right"> <div class="text-center">' + toName + '</div> <img src="/img/avatarChat.png" alt="" /> <p>%@#^text%@#^</p> </div> </li>'
function addMessageToChat(message) {//rewrite dis
    console.log(message);
    let isCurrentUserMessage = message.fromId === thisUserId;
    var template = "";
    if (isCurrentUserMessage) {
        template = sentTemplate.replace("%@#^text%@#^", message.messageContent);
    }
    else {
        template = replyTemplate.replace("%@#^text%@#^", message.messageContent);
    }
    $("#messagesCont").append(template);

}

function clearInputField() {
    messagesQueue.push($("#msgTxt").val());
    $("#msgTxt").val('');
}