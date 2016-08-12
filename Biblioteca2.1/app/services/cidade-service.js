app.service("cidadeService", function ($http) {

    this.getCidades = function (estadoId) {
        return $http.get("/api/Cidade/GetCidadePorEstadoId/" + estadoId);
    }
});