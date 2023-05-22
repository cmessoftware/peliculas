//Funciones helpers

function displayImage(src, width, height) {
    var img = document.createElement("img");
    img.src = src;
    img.width = width;
    img.height = height;
    document.body.appendChild(img);
}


function displayValidationErrors(errors) {
    var $ul = $('ul')
    $ul.empty();

    $.each(errors, function (idx, errorMessage) {
        $ul.append('li' + errorMessage + 'li');
    })

    $('#errors').html($ul);
    $('#divErrors').show();
}