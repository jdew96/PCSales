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
        return $.ajax({
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
        return $http.get("/api/system/GetAll");
    }

    function updateSystem(system) {

        return $.ajax({
            type: 'POST',
            url: "/api/system/UpdateSystem/",
            data: system,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json'
        });
       
    }

}]);

/******** SYSTEMS ************/
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

    var system = { SystemId: 1, SystemName: "Test Edit 2", Price: 189.00,  InventoryCount: 24 };

    systemService.updateSystem(JSON.stringify(system))
        .then(function (response) {
            console.log("response: ", response);
        })

}]);

// Controller for add system page

PcSalesApp.controller("systemAddController", ["systemService", "$window", function (systemService, $window) {
    var vm = this;

    vm.system = null;
    vm.submit = submit;

    function submit() {
        console.log(vm.system);
        systemService.addSystem(JSON.stringify(vm.system))
            .then(function (response) {
                console.log("response: ", response);
                if (response == 1) {
                    alert("Form submitted successfully!");
                    $window.location.href = "/";
                }
                else
                    alert("Error submitted form!");


            });

    }
    
   

}]);

// Controller for delete system page

PcSalesApp.controller("systemDeleteController", ["systemService", "window", function (systemService) {
    var vm = this;

    vm.submit = submit;

     function submit(systemName) {
          systemService.deleteSystem(systemName)
               .then(function (response) {
                    console.log("response: ", response);
                    if (response.data == 1) {
                         alert("System Deleted successfully!");
                         $window.location.href = "/";
                    }
                    else
                         alert("Error Deleting System!");
               });
     }

}]);

/***** END SYSTEMS ********/

/****** CaseSpec *****/

// Set of endpoints to handle CaseSpec CRUD

PcSalesApp.factory("caseSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllCaseSpecs");
    }
}]);

PcSalesApp.controller("caseSpecListController", ["caseSpecService", function (caseSpecService) {

    var vm = this;

    caseSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.caseSpecs = response.data;
        });
}]);

/***** END CASESPEC ****/

/***** CPUSpec *********/
PcSalesApp.factory("cpuSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllCpuSpecs");
    }
}]);

PcSalesApp.controller("cpuSpecListController", ["cpuSpecService", function (cpuSpecService) {

    var vm = this;

    cpuSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.cpuSpecs = response.data;
        });
}]);

/***** END CPUSPEC ****/

/***** GPUSpec *********/
PcSalesApp.factory("gpuSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllGpuSpecs");
    }
}]);

PcSalesApp.controller("gpuSpecListController", ["gpuSpecService", function (gpuSpecService) {

    var vm = this;

    gpuSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.gpuSpecs = response.data;
        });
}]);

/***** END GPUSPEC ****/

/***** MoboSpec *********/
PcSalesApp.factory("moboSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllMoboSpecs");
    }
}]);

PcSalesApp.controller("moboSpecListController", ["moboSpecService", function (moboSpecService) {

    var vm = this;

    moboSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.moboSpecs = response.data;
        });
}]);

/***** END MoboSpec ****/

/***** PsuSpec *********/
PcSalesApp.factory("psuSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllPsuSpecs");
    }
}]);

PcSalesApp.controller("psuSpecListController", ["psuSpecService", function (psuSpecService) {

    var vm = this;

    psuSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.psuSpecs = response.data;
        });
}]);
/***** END PsuSpec ****/

/***** RamSpec *********/
PcSalesApp.factory("ramSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllRamSpecs");
    }
}]);

PcSalesApp.controller("ramSpecListController", ["ramSpecService", function (ramSpecService) {

    var vm = this;

    ramSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.ramSpecs = response.data;
        });
}]);

/***** END RamSpec ****/


/***** StorageSpec *********/
PcSalesApp.factory("storageSpecService", ["$http", function ($http) {
    var service = {
        getAll: getAll
    };
    return service;

    function getAll() {
        return $http.get("/api/PartSpec/GetAllStorageSpecs");
    }
}]);

PcSalesApp.controller("storageSpecListController", ["storageSpecService", function (storageSpecService) {

    var vm = this;

    storageSpecService.getAll()
        .then(function (response) {
            console.log("response: ", response);
            vm.storageSpecs = response.data;
        });
}]);

/***** END StorageSpec ****/

