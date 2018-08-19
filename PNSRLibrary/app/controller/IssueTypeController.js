/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var IssueTypeController = function ($scope, $http, serviceHeader, logService, getDataService) {

        
        //Header
        $scope.config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
        //Service Url
        $scope.ServiceUrl = "http://localhost/LibraryAPI/IssueType";
        //==========================================Request service===========================================================
        var onissueTypes = function (data) {
            $scope.IssueTypeDetails = data;
        };
        var onError = function (reason) {
            logService.LogError(reason, "E");
        };
        getDataService.getObjectData($scope).then(onissueTypes, onError);
        //==========================================Request service===========================================================
    };
    pnsrlibrary.controller("IssueTypeController", ["$scope", "$http", "serviceHeader", "logService","getDataService", IssueTypeController]);
})();