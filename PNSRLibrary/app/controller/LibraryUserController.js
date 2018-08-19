/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var LibraryUserController = function ($scope, $http, serviceHeader, logService, getDataService) {
        $scope.LibraryUserDetails = {};

        $scope.LibraryUsers = function () {
            getDataService.getLibraryUsers($scope);
        };
        $scope.LibraryUsers();
    };
    pnsrlibrary.controller("LibraryUserController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", LibraryUserController]);
})();