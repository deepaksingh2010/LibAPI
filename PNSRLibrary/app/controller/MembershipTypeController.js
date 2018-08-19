/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var MembershipTypeController = function ($scope, $location, $interval, $http, serviceHeader, logService, getDataService) {

        $scope.Memberships = {};

        $scope.SaveMemberShipType = function (data) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.post("http://localhost/LibraryAPI/MemberShipType", data, config).then(
              function (response) {
                  logService.LogError(response.headers("Location"),"I");
                  $scope.Membershiptypes();
                  $scope.data= {
                      MemberShipTypeName: null,
                      MaxIssueDays: 0
                  };
              },
              function (data) {
                  $scope.data.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.data.error, "E");
              });
        };

        $scope.DeleteMemberShipType = function (data) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.delete("http://localhost/LibraryAPI/MemberShipType/" + data.MembershipTypeID, config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.Membershiptypes();
              },
              function (data) {
                  $scope.data.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.data.error, "E");
              });
        };

        $scope.Membershiptypes = function () {
            getDataService.getMembershipTypes($scope);
        };
        $scope.Membershiptypes();
    };
    pnsrlibrary.controller("MembershipTypeController", ["$scope", "$location", "$interval", "$http", "serviceHeader", "logService","getDataService", MembershipTypeController]);
})();