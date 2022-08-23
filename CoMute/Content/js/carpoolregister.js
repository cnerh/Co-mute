
; (function (root, $) {
    $('#CarPoolRegister').on('submit', function (ev) {
        ev.preventDefault();
               

        var Departuretime = $('#Departuretime').val();
       if (!Departuretime) {
            return;
        }

        var ExpectedArrivaltime = $('#ExpectedArrivaltime').val();
        if (!ExpectedArrivaltime) {
            return;
        }

        var Origin = $('#Origin').val();
        if (!Origin) {
            return;
        }

        var Daysavailable = $('#Daysavailable').val();
        if (!Daysavailable) {
            return;
        }

        var Destination = $('#Destination').val();
        if (!Destination) {
            return;
        }

        var Availableseats = $('#Availableseats').val();
        if (!Availableseats) {
            return;
        }

        var Owner = $('#Owner').val();
        if (!Owner) {
            return;
        }
        var Notes = $('#Notes').val();
        if (!Notes) {
            return;
        }

        var requestdata = { Departuretime: Departuretime, ExpectedArrivaltime: ExpectedArrivaltime, Origin: Origin, Daysavailable: Daysavailable, Destination: Destination, Availableseats: Availableseats, Owner: Owner, Notes: Notes}

        $.post('/CarPool/add',
            requestdata, function (data) {
                // TODO: Navigate away...
             

                window.location.href = "CarPoolView";

            })
          
            .fail(function (data) {
                var $alert = $("#error");
                var $p = $alert.find("p");
                $p.text('Registration failed');
                $alert.removeClass('hidden');



                setTimeout(function () {
                    $p.text('');
                    $alert.addClass('hidden');
                }, 3000);
            });
    });
})(window, jQuery);

