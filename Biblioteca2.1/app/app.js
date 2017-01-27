var app = angular.module("app", ['ngRoute', 'ui.bootstrap']);

app.config(function ($routeProvider, $locationProvider) {

    $routeProvider
   .when("/",
        { templateUrl: 'views/cliente/index.html' })
   .when("/cliente/form",
        { templateUrl: 'views/cliente/form.html' })
   .when("/cliente/form/:id",
        { templateUrl: 'views/cliente/form.html' })
   .otherwise(
        { redirectTo: "/" });
});

(function () {
    $("form").validationEngine('attach');
}());

