
; (function (root, $) {
    //var table;

    $(document).ready(function () {

        $.get('/Carpool/get', function (data) {
           // $("#cartableView tr").detach();
            
            $.each(data, function (index, value) {


                $('#cartableView tbody:eq(0)').append('<tr><td>' +
                    value.DepartureTime + '</td><td>' +
                    value.ExpectedArrivaltime +
                    '</td><td>' + value.Origin +
                    '</td><td>' + value.DaysAvailable +
                    '</td><td>' + value.Destination + '</td><td>' +
                    value.AvailableSeats + '</td><td>' + value.Owner +
                    '</td><td>' + value.Notes +
                    '</td><td> <button id="join" value="' + value.CarPoolID + '" calss="btn btn - danger btnEdit" >Join</button> </td></tr>');

                if (value.CarPoolID != null) {

                    $("#join").html("leave");

                }
               

            })

            


            $('body').on('click', '#join', function ()
           // $("#join").click(function ()
            {
         
              
                var CarID = $("#join").val();

                var requestdata = { CarPoolID: CarID }

                $.post('/RegistrationRequest/Assign',
                    requestdata, function (data) {
                        //  $("#join").text = "leave";
                        // $("#join").html("leave");


                        //var btnvalue = $("#join").html();
                        //if (btnvalue == 'Join') {
                        //    $("#join").html("leave");
                        //}


                        //// $("#join").prop("value", "leave");
                        //else {
                        //    $("#join").html("Join");

                        //}

                    })
            })

        //    })

      
         

        $("#Search").click(function () {
     

            var Destination = $('#Destination').val();
            if (!Destination) {
                return;
            }

            var dataRequest = { Destination: Destination }
            $.get('/Carpool/search', dataRequest, function (data) {
                $("#cartableView tr").detach();

                $.each(data, function (index, value) {
                   
                    $('#cartableView tbody:eq(1)').append('<tr><td>' + value.DepartureTime + '</td><td>' + value.ExpectedArrivaltime +
                        '</td><td>' + value.Origin + '</td><td>' + value.DaysAvailable + '</td><td>' + value.Destination + '</td><td>' + value.AvailableSeats + '</td><td>' + value.Owner + '</td><td>' + value.Notes + '</td><td> <button id="join" calss="btn btn-danger btnEdit" >Join</button> </td></tr>');
                })
            })

        })

        });
   })
  
})(window, jQuery);
