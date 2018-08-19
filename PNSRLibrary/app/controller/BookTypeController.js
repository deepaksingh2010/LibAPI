/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var BookTypeController = function ($scope, $http, serviceHeader, logService, getDataService) {
        $scope.BookTypeDetails = {};

        $scope.BookTypes = function () {
            getDataService.getBookTypes($scope);
        };
        $scope.BookTypes();
    };
    pnsrlibrary.controller("BookTypeController", ["$scope", "$http", "serviceHeader", "logService","getDataService", BookTypeController]);
})();