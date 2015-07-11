function GetAllEmployees() {
    //jQuery.support.cors = true;
    $.ajax({
        url: 'http://localhost:37000/api/shoppingcart',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            console.debug(data);
            //$("#output").html(data.tostring());
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}


// A $( document ).ready() block.

$(document).ready(function () {
    
    $("#getdata").click(function(){
        GetAllEmployees();
});

});

