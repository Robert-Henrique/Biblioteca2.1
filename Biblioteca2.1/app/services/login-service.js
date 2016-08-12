app.service("loginService", function ($http) {

    this.logar = function (login) {
        var response = $http({
            method: "post",
            url: "Login/Logar",
            data: JSON.stringify(login),
            dataType: "json"
        });
        return response;
    };
});