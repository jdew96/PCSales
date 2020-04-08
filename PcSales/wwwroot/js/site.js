// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Define app module which will be used to instantiate all controllers and services
var PcSalesApp = angular.module("PcSalesApp", []);


// Set of endpoints to handle system data CRUD
PcSalesApp.factory("systemService", ["$http", function ($http) {
    var service = {
        addSystem: addSystem,
        deleteSystem: deleteSystem,
        getAll: getAll,
        updateSystem: updateSystem
        // List of functions, seperated by comma
    };
    return service;

    function addSystem(system) {
        $.ajax({
            type: 'POST',
            url: "/api/system/AddSystem/",
            data: system,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json'
        });
    }

    function deleteSystem(id) {

        return $http.post("/api/system/DeleteSystem/" + id);
    }

    function getAll() {
        return $http.get("api/system/GetAll");
    }

    function updateSystem(system) {

        $.ajax({
            type: 'POST',
            url: "/api/system/UpdateSystem/",
            data: system,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json'
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

// Controller for update system page

PcSalesApp.controller("systemUpdateController", ["systemService", function (systemService) {
    var vm = this;

    var system = { SystemId: 1, SystemName: "Test Edit 1", Price: 127.00,  InventoryCount: 12 };

    systemService.updateSystem(JSON.stringify(system))
        .then(function (response) {
            console.log("response: ", response);
        })

}]);

// Controller for add system page

PcSalesApp.controller("systemAddController", ["systemService", function (systemService) {
    var vm = this;

    var system = { SystemName: "Test Add 1", Price: 127.00, InventoryCount: 12 };

    systemService.addSystem(JSON.stringify(system))
        .then(function (response) {
            console.log("response: ", response);
        })

}]);

// Controller for delete system page

PcSalesApp.controller("systemDeleteController", ["systemService", function (systemService) {
    var vm = this;

    // Delete system with systemId 4
    systemService.deleteSystem(4)
        .then(function (response) {
            console.log("response: ", response);
        })

}]);