app.service("estadoService", function ($http) {

    this.getEstados = function () {
        return $http.get("/api/Estado/GetEstado");
    }
});