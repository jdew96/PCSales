// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Define app module which will be used to instantiate all controllers and services
var PcSalesApp = angular.module("PcSalesApp", []);

// Set of endpoints to handle system data CRUD
PcSalesApp.factory("systemService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("api/system/getAll");
    }

}]);

// Controller for systems index page

PcSalesApp.controller("loadTestController", ["systemService", function (systemService) {
    var vm = this;

    systemService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.systems = response.data;
            //console.log("systems: ", vm.systems);
        });
   

}]);