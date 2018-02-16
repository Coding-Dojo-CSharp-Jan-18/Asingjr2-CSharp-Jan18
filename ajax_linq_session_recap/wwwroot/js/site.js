// Write your Javascript code.
//  Adding basic jquery function for AJAX

$(document).ready(function(){
    
})
    $("#hide").click(function() {
        $("#teams_list").hide();
    })
        
    $("#show").click(function() {
        $("#teams_list").show();

    })
        // event = event object 
    $("#form").submit(function(event) {
        event.preventDefault();
        var data = $("#form").serialize();

        $.ajax({
            method: "POST",
            url: "create",
            data: data,
            success: function(res){
                console.log("hey");
            }
        })
    })

        

    
