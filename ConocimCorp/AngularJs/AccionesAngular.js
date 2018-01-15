var app = angular.module("app", ["ngRoute"])
    .config(function($routeProvider, $locationProvider){

        $routeProvider.when('/', {
            templateUrl: '/Views/Products/Index.cshtml',
            controller: 'bienvenidoController'
        });
        $locationProvider.html5Mode(true);
});