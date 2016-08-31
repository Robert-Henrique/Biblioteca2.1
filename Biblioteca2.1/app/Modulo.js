var app = angular.module("app", ['ngRoute', 'ui.bootstrap']);

app.config(function ($routeProvider, $locationProvider) {

    $routeProvider
   .when("/",
        { templateUrl: 'app/templates/cliente/index.html' })
   .when("/cliente/detalhes",
        { templateUrl: 'app/templates/cliente/detalhes.html' })
   .when("/cliente/detalhes/:id",
        { templateUrl: 'app/templates/cliente/Detalhes.html' })
   .otherwise(
        { redirectTo: "/" });
});

(function () {
    $("form").validationEngine('attach');
}());

