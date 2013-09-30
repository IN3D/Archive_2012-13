<script src="jquery-1.10.2.min.js" type="text/javascript"></script>
var priceData = {
    camembert: 18,
    tomme: 19,
    morbier: 9
    }
        
    //creates the new button and creates its on-click event
    $(document).ready(function() {
        $('#buttonDiv input:submit').hide();
        $('<a href=#>Submit Order</a>').appendTo("#buttonDiv")
        .addClass("button").click(function(){
            $('form').submit();
        })
        //creates the on hover event that causes the button to change color
        .hover(function(e){
            var elem = $('#buttonDiv a')
            if (e.type === "mouseenter") {
                elem.addClass("buttonHover");
            } else {
                elem.removeClass("buttonHover");
            }
        });
        /*this allows any user with JavaScript enabled to see the elements
        of the site that are assigned to the latent class.
        if a user does not have JavaScript enabled they will not be able to
        see these elements of the site.*/
        $('.latent').show();
            
        /*where the name of the value in the PriceData variable is equal to the
        input name of the div of each cheese the value entered by the user is
        multipled by the value provided from PriceData.*/
        //
        /*The events "change" and "keyup" are bound together so that any user
        input will always cause an update to the value.*/
        $('input').bind("change keyup", function() {
            var subtotal = $(this).val() * priceData[this.name];
            $(this).siblings("span").children("span").text(subtotal)
            calculateTotal();
        })
        /*The book suggests:
        &('form').attr("action", "/shipping");
        but this leads into the C: drive, not into the containing folder*/
        $('form').attr("action", "shipping.html");
    })
        
    /*Calculates the complete total of the order:
    takes the value from each span class that contains "subtotal" but not the id
    "total" (to avoid calculating the current total with the old total in the math)
    the each method does for each elemet in the jQuery object, goes through and adds
    to the total by turning the text value of the HTMLElement's text to a Number.*/
    function calculateTotal() {
        var total = 0;
        $('span.subtotal span').not('#total').each(function(index, elem){
            total += Number($(elem).text());
        })
        $('#total').text("$"+total);
    }