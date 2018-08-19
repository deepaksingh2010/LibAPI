/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var MemeberShipController = function ($scope, $http, serviceHeader, logService, getDataService) {
        //get Library user and bind to drop down.
        $scope.LibraryUserDetails = {};

        $scope.LibraryUsers = function () {
            getDataService.getLibraryUsers($scope);
        };
        $scope.LibraryUsers();

        //get Membership Types and bind to drop down
        $scope.Memberships = {};
        $scope.Membershiptypes = function () {
            getDataService.getMembershipTypes($scope);
        };
        $scope.Membershiptypes();

        //get Membership Statuses and bind to drop down
        $scope.MemberShipStatusesDetails = {};
        $scope.MemberShipStatuses = function () {
            getDataService.getMembershipStatues($scope);
        };
        $scope.MemberShipStatuses();

        //get Membership and bind to table
        $scope.LibMemeberShipDetails = {};
        $scope.LibMemeberShip = function () {
            getDataService.getLibMemeberShip($scope);
        };
        $scope.LibMemeberShip();

    };
    pnsrlibrary.controller("MemeberShipController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", MemeberShipController]);
})();