function handleSendMessage() {
    var chat = document.querySelector(".message-stream");
    chat.scroll({
        top: chat.scrollHeight,
        behavior: 'smooth'
    });
    var input = document.querySelector(".message-input");
    input.focus();
}