/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var MembershipStatusController = function ($scope, $http, serviceHeader, logService, getDataService) {

        $scope.MemberShipStatusesDetails = {};

        $scope.MemberShipStatuses = function () {
            getDataService.getMembershipStatues($scope);
        };
        $scope.MemberShipStatuses();
    };
    pnsrlibrary.controller("MembershipStatusController", ["$scope", "$http", "serviceHeader", "logService","getDataService", MembershipStatusController]);
})();