////; (function (root, $) {
////    $('#Search').on('submit', function (ev) {
////        ev.preventDefault();

////        var Destination = $('#Destination').val();
////        if (!Destination) {
////            return;
////        }

////        var dataRequest = { Destination: Destination }
////        $.get('/Carpool/search', dataRequest, function (data) {

////            $.each(data, function (index, value) {
////                //  DepartureTime.append("<li>" + value.DepartureTime + "</li>");
////                //DepartureTime.append(value);
////                //easy.append(value.DepartureTime);
////                //ExpectedArrivaltime.append(value.ExpectedArrivaltime)
////                $('#cartable tbody').append('<tr><td>' + value.DepartureTime + '</td><td>' + value.ExpectedArrivaltime +
////                    '</td><td>' + value.Origin + '</td><td>' + value.DaysAvailable + '</td><td>' + value.Destination + '</td><td>' + value.availableseats + '</td><td>' + value.Owner + '</td><td>' + value.Notes + '</td><td> <button id="join" calss="btn btn-danger btnEdit" >Join</button> </td></tr>');
////            })
////        })

////    })
////})
  
//// (window, jQuery);