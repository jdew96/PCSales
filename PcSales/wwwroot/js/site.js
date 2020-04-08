// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Define app module which will be used to instantiate all controllers and services
var PcSalesApp = angular.module("PcSalesApp", []);


/** CODE FOR SYSTEM LIST PAGE ***/
// Set of endpoints to handle system data CRUD
PcSalesApp.factory("systemService", ["$http", function ($http) {
    var service = {
        getAll: getAll,
        update: update
        // List of functions, seperated by comma
    };
    return service;

    function getAll() {
        return $http.get("api/system/GetAll");
    }

    function update(system) {

        $.ajax({
            type: 'POST',
            url: "/api/system/UpdateSystem/",
            data: system,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) { console.log(data) }
        });
       
    }

}]);

// Controller for systems index page

PcSalesApp.controller("systemListController", ["systemService", function (systemService) {
    var vm = this;

    systemService.getAll()
        .then(function (response) {
            console.log("all systems: ", response);
            vm.systems = response.data;
        });

}]);

// Controller for systems index page

PcSalesApp.controller("systemUpdateController", ["systemService", function (systemService) {
    var vm = this;

    var system = { SystemId: 1, SystemName: "Test Edit 1", Price: 127.00,  InventoryCount: 12 };

    systemService.update(JSON.stringify(system))
        .then(function (response) {
            console.log("response: ", response);
        })

}]);