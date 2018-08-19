/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var LateFeeDetailController = function ($scope, $http, serviceHeader, logService, getDataService) {
        $scope.LateFeeDetails = {};

        $scope.allLateFeeDetails = function () {
            getDataService.getLateFeeDetails($scope);
        };
        $scope.allLateFeeDetails();
    };
    pnsrlibrary.controller("LateFeeDetailController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", LateFeeDetailController]);
})();