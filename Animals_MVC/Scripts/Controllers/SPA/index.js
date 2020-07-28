$('#animals').click(function () {
    $.ajax({
        type: 'GET',
        url: '/api/test',
        success: function (data) {
            var result = '<ul>';
            data.forEach((item) => {
                result += '<li>' + item.Name + '</li>';
            })

            var endResult = result + '</ul>';
            $('.list-container').empty().append(endResult);
        },
        error: function (msg) {
            alert('Server error', msg);
        }
    });
});