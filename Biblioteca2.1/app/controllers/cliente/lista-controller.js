angular.module("app").controller("listaClienteController", function ($scope, clienteService) {

    $scope.currentPage = 1;
    $scope.maxSize = 10;
    $scope.filtro = "";
    $scope.clientes = [];

    $scope.obterClientes = function () {
        clienteService.getClientes($scope.currentPage, $scope.maxSize, $scope.filtro).success(function (data) {
            $scope.clientes = data.Clientes;
            $scope.totalItens = data.totalItens;
            $scope.numPages = data.numPages;
        }).error(function (erro) {
            console.log(erro);
        });
    };

    $scope.excluir = function (cliente) {
        clienteService.excluir(cliente);
    };

    $scope.paginaAlterada = function () {
        $scope.obterClientes();
    };

    $scope.pesquisaAlterada = function () {
        $scope.obterClientes();
    };
});