; (function (root, $) {
    $('#login').on('submit', function (ev) {
        ev.preventDefault();
        var email = $('#inputEmail').val();
        if (!email) {
            return;
        }

        var pswd = $('#inputPassword').val();
        if (!pswd) {
            return;
        }
       

            $.post('Authentication/login', { email: email, password: pswd }, function (data) {
                // TODO: Navigate away...
                if (data != null)
             //       $.session.set("ID", data.ID);

                    window.location.href = "Home/JoinedView";
            }).fail(function (data) {
                var $alert = $("#error");
                var $p = $alert.find("p");
                $p.text('Incorrect email and password combination');
                $alert.removeClass('hidden');

                setTimeout(function () {
                    $p.text('');
                    $alert.addClass('hidden');
                }, 3000);
            });
        });




    $.get('/Authentication/getbyid', function (data) {
        $.each(data, function (index, value) {
            var name = value.Name;

            $("#name").val(name);
            $("#surname").val(value.Surname)
            $("#phone").val(value.PhoneNumber)
            $("#email").val(value.EmailAddress)
            $("#password").val(value.Password)

        })
    })

    $("#save").click(function () {


        var requestdata = { name: $("#name").val(), surname: $("#surname").val(), phoneNumber: $("#phone").val(), emailAddress: $("#email").val(), password: $("#password").val() }

        $.post('/RegistrationRequest/updateDetails',
            requestdata, function (data) {
                // TODO: Navigate away...
                window.location.href = "/Home/Profile";


            })

                

    })


})(window, jQuery);