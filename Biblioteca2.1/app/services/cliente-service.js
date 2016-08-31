app.service("clienteService", function ($http) {

    this.getClientes = function (range, totalItens, filtro) {
        return $http.get("/api/Cliente/GetCliente/" + range + "/" + totalItens + "/" + filtro);
    };

    this.getCliente = function (Id) {
        return $http.get("api/cliente/GetCliente/" + Id);
    }

    this.salvar = function (cliente) {
        if (cliente.Id > 0)
            return $http.put("api/Cliente/PutCliente/" + cliente.Id, cliente);

        return $http.post("api/Cliente/PostCliente/", cliente);
    };

    this.excluir = function (cliente) {
        return $http.delete("api/Cliente/DeleteCliente/" + cliente.Id);
    };
});