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
        getSystem: getSystem,
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

    function getSystem(sysId) {
        return $http.get("/api/system/GetSystem/" + sysId);
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

PcSalesApp.controller("systemListController", ["$window", "systemService",function ($window, systemService) {
    var vm = this;
    vm.update = update;

    systemService.getAll()
        .then(function (response) {
            console.log("all systems: ", response);
            vm.systems = response.data;
        });

   
    function update(sysId) {
        $window.location.href = "/System/Update/?id=" + sysId;
    }

}]);

// Controller for update system page

PcSalesApp.controller("systemUpdateController", ["systemService", "partSpecService", function (systemService, partSpecService) {
    var vm = this;
    vm.system = null;
    vm.removePart = removePart;
    vm.addPart = addPart;
    vm.parts = [];
    vm.potentialParts = [];

    function getUrlVars() {
        var vars = {};
        var parts = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
            vars[key] = value;
        });
        return vars;
    }

    var id = getUrlVars()["id"];

    systemService.getSystem(id)
        .then(function (response) {
            vm.system = response.data;
        });

    partSpecService.getAllPartsForSystem(id)
        .then(function (response) {
            // Add each part to array of parts
            angular.forEach(response.data, function (value, key) {
                vm.parts.push(value);
            });
            console.log(vm.parts);
        });

    partSpecService.getAllPotentialParts(id)
        .then(function (response) {
            angular.forEach(response.data, function (value, key) {
                if (value != []) { // only add items that aren't empty list 
                    angular.forEach(value, function (part) {
                        vm.potentialParts.push(part);
                    });
                }
            });
        });

    function removePart(part) {
        vm.parts = vm.parts.filter(function (el) { return el.partNum != part.partNum; }); // Remove this part from list
        vm.potentialParts.push(part); // Add to potential parts list
    }

    function addPart(part) {
        vm.parts.push(part); // Add part to list

        // Remove part from potential parts list 
        vm.potentialParts = vm.potentialParts.filter(function (el) { return el.partNum != part.partNum; }); 
    }

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

     function submit(id) {
          systemService.deleteSystem(id)
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

/***** Part Specs *********/
// Set of endpoints to handle part spec CRUD
PcSalesApp.factory("partSpecService", ["$http", function ($http) {
    var service = {
        getAllCaseSpecs: getAllCaseSpecs,
        getAllCpuSpecs: getAllCpuSpecs,
        getAllGpuSpecs: getAllGpuSpecs,
        getAllMoboSpecs: getAllMoboSpecs,
        getAllPsuSpecs: getAllPsuSpecs,
        getAllRamSpecs: getAllRamSpecs,
        getAllStorageSpecs: getAllStorageSpecs,
        getAllPartsForSystem: getAllPartsForSystem,
        getAllPotentialParts: getAllPotentialParts
    };
    return service;

    function getAllCaseSpecs() {
        return $http.get("/api/PartSpec/GetAllCaseSpecs");
    }

    function getAllCpuSpecs() {
        return $http.get("/api/PartSpec/GetAllCpuSpecs");
    }

    function getAllGpuSpecs() {
        return $http.get("/api/PartSpec/GetAllGpuSpecs");
    }

    function getAllMoboSpecs() {
        return $http.get("/api/PartSpec/GetAllMoboSpecs");
    }

    function getAllPsuSpecs() {
        return $http.get("/api/PartSpec/GetAllPsuSpecs");
    }

    function getAllRamSpecs() {
        return $http.get("/api/PartSpec/GetAllRamSpecs");
    }

    function getAllStorageSpecs() {
        return $http.get("/api/PartSpec/GetAllStorageSpecs");
    }

    function getAllPartsForSystem(sysId) {
        return $http.get("/api/PartSpec/GetSpecsForSystem/" + sysId);
    }

    function getAllPotentialParts(sysId) {
        return $http.get("/api/PartSpec/getPotentialParts/" + sysId);
    }
}]);

/****** CaseSpec *****/
PcSalesApp.controller("caseSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllCaseSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.caseSpecs = response.data;
        });
}]);
/***** END CASESPEC ****/

/***** CPUSpec *********/
PcSalesApp.controller("cpuSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllCpuSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.cpuSpecs = response.data;
        });
}]);

/***** END CPUSPEC ****/

/***** GPUSpec *********/
PcSalesApp.controller("gpuSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllGpuSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.gpuSpecs = response.data;
        });
}]);

/***** END GPUSPEC ****/

/***** MoboSpec *********/
PcSalesApp.controller("moboSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllMoboSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.moboSpecs = response.data;
        });
}]);

/***** END MoboSpec ****/

/***** PsuSpec *********/
PcSalesApp.controller("psuSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllPsuSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.psuSpecs = response.data;
        });
}]);
/***** END PsuSpec ****/

/***** RamSpec *********/
PcSalesApp.controller("ramSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllRamSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.ramSpecs = response.data;
        });
}]);

/***** END RamSpec ****/


/***** StorageSpec *********/
PcSalesApp.controller("storageSpecListController", ["partSpecService", function (partSpecService) {

    var vm = this;

    partSpecService.getAllStorageSpecs()
        .then(function (response) {
            console.log("response: ", response);
            vm.storageSpecs = response.data;
        });
}]);

/***** END StorageSpec ****/

