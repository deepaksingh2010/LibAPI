/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    var BooksCategoryController = function ($scope, $http, serviceHeader, logService, getDataService) {
        $scope.BooksCategoryDetails = {};

        $scope.BooksCategories = function () {
            getDataService.getBooksCategories($scope);
        };
        $scope.BooksCategories();
    };
    pnsrlibrary.controller("BooksCategoryController", ["$scope", "$http", "serviceHeader", "logService", "getDataService", BooksCategoryController]);
})();