var sipamu = {
    initialize: function () {
        console.log('Sipamu scripts on and up!');
        this.bindEvents();
    },
    bindEvents: function () {
        $('#VC_LOGIN').unbind('blur').blur(this.loginChanged);
    },
    loginChanged: function () {
        if (this.value != '') {
            $(this).next('span').html('Validando...').show();
            $.ajax({
                url: '/Usuarios/ValidateUser',
                data: { userName: this.value },
                success: function (data) {
                    alert(data);
                    $('#VC_LOGIN').next('span').html(data).show();
                }
            });


            
        }
    }
}