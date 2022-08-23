
; (function (root, $) {
    $(document).ready(function () {

        $.get('/Carpool/getJoined', function (data) {

            $.each(data, function (index, value) {

                $('#cartable tbody:eq(1)').append('<tr><td>' + value.DepartureTime + '</td><td>' + value.ExpectedArrivaltime +
                    '</td><td>' + value.Origin + '</td><td>' + value.DaysAvailable + '</td><td>' + value.Destination + '</td><td>' + value.AvailableSeats + '</td><td>' + value.Owner + '</td><td>' + value.Notes + '</td></tr>');

            })

        })
    })

})(window, jQuery);