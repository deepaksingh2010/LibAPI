/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var BookIssueStatusController = function ($scope, $http, serviceHeader, logService, getDataService) {
        $scope.BookIssueStatusDetails = {};

        $scope.BookIssueStatuses = function () {
            getDataService.getBookIssueStatus($scope);
        };
        $scope.BookIssueStatuses();
    };
    pnsrlibrary.controller("BookIssueStatusController", ["$scope", "$http", "serviceHeader", "logService","getDataService", BookIssueStatusController]);
})();