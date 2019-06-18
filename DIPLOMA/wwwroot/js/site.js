
// Accommodation

var objSel = document.getElementById("DirectoryStatusAccommodationID");
var blockHidden_1 = document.getElementById("block_for_hidden__accommodation_1");
var blockHidden_3 = document.getElementById("block_for_hidden__accommodation_3");


if (objSel.options[objSel.selectedIndex].text == "Бронирование") {
    blockHidden_1.style.display = 'none';
    blockHidden_3.style.display = 'none';
}

objSel.addEventListener("change", function () {

    if (objSel.options[objSel.selectedIndex].text == "Бронирование") {
        blockHidden_1.style.display = 'none';
        blockHidden_3.style.display = 'none';
    }
    if (objSel.options[objSel.selectedIndex].text == "Заселение") {
        blockHidden_1.style.display = 'block';
        blockHidden_3.style.display = 'block';
    }
    if (objSel.options[objSel.selectedIndex].text == "Выселение") {
        blockHidden_1.style.display = 'block';
        blockHidden_3.style.display = 'block';
    }
    if (objSel.options[objSel.selectedIndex].text == "Отмена") {
        blockHidden_1.style.display = 'block';
        blockHidden_3.style.display = 'block';
    }
}) 

$(document).ready(function () {

    $('#buttonNumber').click(function () {
        var DirectoryCategoryRooms = $('#DirectoryCategoryRooms :selected').text();
        var DirectoryTypeRooms = $('#DirectoryTypeRooms :selected').text();
        var asd = "Hello";
        //$('#NumberRoom').html(DirectoryTypeRooms);
        $.ajax({
            type: 'POST',
            url: '/DocumentAccommodationsController/NumberFree/',
            contentType: "application/json",
            data: { DirectoryCategoryRooms: DirectoryCategoryRooms, DirectoryTypeRooms: DirectoryTypeRooms },
            success: function (result) {
                $('#NumberRoom').html(result);
            }
        });
    });
});

