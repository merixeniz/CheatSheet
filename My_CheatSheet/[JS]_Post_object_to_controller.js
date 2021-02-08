    function startService() {

        let services = [];
        let Cliglt = { serviceName: 'Cliglt_' + $('#device_ip').val() };
        let Scaner_11 = { serviceName: 'ATNetService_' + $('#scaner_name').val() };

        services.push(Cliglt);
        services.push(Scaner_11);

        $.post('@Url.Action("StartServices", "DeviceConfigurator")',
                        {
                            services: JSON.stringify(services)
                        });


    }
    
    //POST data and process response (FRONTEND) - In backend we need MethodName(string usrID, string usrLogin)
    function editUser(userID, userLogin) {
        $.post('@Url.Action("MethodName", "ControllerName")', {
            usrID: userID.innerHTML,
            usrLogin: userLogin.innerHTML
        }).done(function (response) {
            console.log(response);
        });
    }