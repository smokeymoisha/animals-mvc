$('#dark-mode').click(() => {
    if ($('#dark-mode').text() == 'Dark Mode') {
        $('body').css("background-color", "grey");
        $('#dark-mode').html('Light Mode');
    } else {
        $('body').css("background-color", "white");
        $('#dark-mode').html('Dark Mode');
    }
});