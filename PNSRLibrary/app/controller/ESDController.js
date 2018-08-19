(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var ESDController = function ($scope, $http, serviceHeader, logService, getDataService, $filter) {
        $scope.data = {};
        $scope.ESDmetadata = [
      {
          "Latitude": "24.23424",
          "Longitude": "34.28778"
      },
      {
          "Latitude": "24.23424",
          "Longitude": "34.28778"
      },
      {
          "Latitude": "24.23424",
          "Longitude": "34.28778"
      },
      {
          "Latitude": "24.23424",
          "Longitude": "34.28778"
      },
      {
          "Latitude": "24.23424",
          "Longitude": "34.28778"
      }
    ]

    };
    pnsrlibrary.controller("ESDController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", "$filter", ESDController]);
})();