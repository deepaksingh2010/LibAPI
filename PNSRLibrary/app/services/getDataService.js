/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");

    var getDataService = function ($http, serviceHeader, logService) {
        var factory = {};
        
        factory.getObjectData = function ($scope) {
            return $http.get($scope.ServiceUrl, $scope.config)
              .then(function (response) {
                  $scope.error = { message: response.status, status: response.statusText };
                  logService.LogError($scope.error, "I");
                  return response.data;
              });
        };
        factory.getBookIssueStatus = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/BookIssueStatus", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.BookIssueStatusDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getBooksCategories = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/BooksCategory", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.BooksCategoryDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getBookTypes = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/BookType", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.BookTypeDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getIssueTypes = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/IssueType", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.IssueTypeDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getLateFeeDetails = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/LateFeeDetail", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.LateFeeDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getMembershipStatues = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/MemberShipStatus", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.MemberShipStatusesDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getMembershipTypes = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/MemberShipType", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.Memberships = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getLibraryUsers = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/LibraryUser", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.LibraryUserDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getLibMemeberShip = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/LibMemberShip", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.LibMemeberShipDetails = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        factory.getBooks = function ($scope) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.get("http://localhost/LibraryAPI/Book", config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  $scope.Books = response.data;
              },
              function (data) {
                  $scope.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.error, "E");
              });
        }
        return factory;
    };
    pnsrlibrary.factory("getDataService", ["$http", "serviceHeader", "logService",getDataService]);
})();