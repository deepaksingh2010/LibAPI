/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var BookIssuedController = function ($scope, $http, serviceHeader, logService, getDataService, $filter) {
        $scope.IsUpate = false;
        $scope.toggleclick = function (IsUpate) {
            if (IsUpate == false) {
                $scope.IsUpate = true;
            }
            else {
                $scope.IsUpate = false;
            }
        }
        $scope.data = {};
        $scope.UpdateBookIssued = function (dataUpdate) {
            $scope.toggleclick($scope.IsUpate);
            $scope.data = dataUpdate;
            $scope.data.UserID = dataUpdate.LibraryUser.LibraryUserID;
            $scope.data.RetrunDate = new Date($filter('date')(dataUpdate.RetrunDate, "MM/dd/yyyy"));
            $scope.data.IssueDate =new Date($filter('date')(dataUpdate.IssueDate, "MM/dd/yyyy"));
            
            //var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            //return $http.put("http://localhost/LibraryAPI/BookIssued/" + data, config).then(
            //  function (response) {
            //      logService.LogError(response.headers("Location"), "I");
            //      $scope.Membershiptypes();
            //  },
            //  function (data) {
            //      $scope.data.error = { message: data.status, status: data.statusText };
            //      logService.LogError($scope.data.error, "E");
            //  });
        };
        //Update book issue data
        $scope.UpdateBookIssue = function (data) {
            var config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
            return $http.put("http://localhost/LibraryAPI/BookIssued", data, config).then(
              function (response) {
                  logService.LogError(response.headers("Location"), "I");
                  getDataService.getObjectData($scope).then(onissueTypes, onError);
              },
              function (data) {
                  $scope.data.error = { message: data.status, status: data.statusText };
                  logService.LogError($scope.data.error, "E");
              });
        };
        //get Books Category and bind to drop down.
        $scope.BooksCategoryDetails = {};
        $scope.BooksCategories = function () {
            getDataService.getBooksCategories($scope);
        };
        $scope.BooksCategories();

        //get Library user and bind to drop down.
        $scope.LibraryUserDetails = {};
        $scope.LibraryUsers = function () {
            getDataService.getLibraryUsers($scope);
        };
        $scope.LibraryUsers();


        //get Book Issue Status and bind to drop down.
        $scope.BookIssueStatusDetails = {};
        $scope.BookIssueStatuses = function () {
            getDataService.getBookIssueStatus($scope);
        };
        $scope.BookIssueStatuses();        
        

        //Header
        $scope.config = serviceHeader.GetServiceHeader("HeaderJsonConfig");
        //Service Url
        $scope.ServiceUrl = "http://localhost/LibraryAPI/BookIssued";
        //==========================================Request service===========================================================
        var onissueTypes = function (data) {
            $scope.BookIssuedDetails = data;
        };
        var onError = function (reason) {
            logService.LogError(reason, "E");
        };
        getDataService.getObjectData($scope).then(onissueTypes, onError);
    };
    pnsrlibrary.controller("BookIssuedController", ["$scope", "$http", "serviceHeader", "logService","getDataService","$filter", BookIssuedController]);
})();