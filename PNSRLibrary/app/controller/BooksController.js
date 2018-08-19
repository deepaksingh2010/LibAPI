/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var BooksController = function ($scope, $http, serviceHeader, logService, getDataService) {

        //get Books Category and bind to drop down.
        $scope.BooksCategoryDetails = {};
        $scope.BooksCategories = function () {
            getDataService.getBooksCategories($scope);
        };
        $scope.BooksCategories();

        //get Book Types and bind to drop down.
        $scope.BookTypeDetails = {};
        $scope.BookTypes = function () {
            getDataService.getBookTypes($scope);
        };
        $scope.BookTypes();

        //get LateFee Details and bind to drop down.
        $scope.LateFeeDetails = {};
        $scope.allLateFeeDetails = function () {
            getDataService.getLateFeeDetails($scope);
        };
        $scope.allLateFeeDetails();

        $scope.Books = {};
        $scope.allBooks = function () {
            getDataService.getBooks($scope);
        };
        $scope.allBooks();
    };
    pnsrlibrary.controller("BooksController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", BooksController]);
})();