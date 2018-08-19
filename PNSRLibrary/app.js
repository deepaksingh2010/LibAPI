/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary", ["ngRoute"]);
    pnsrlibrary.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/MembershipType", {
                templateUrl: "template/MembershipType.html",
                controller: "MembershipTypeController"
            })
            .when("/MemeberShip", {
                templateUrl: "template/MemeberShip.html",
                controller: "MemeberShipController"
            })
            .when("/MemberShipStatus", {
                templateUrl: "template/MemberShipStatus.html",
                controller: "MembershipStatusController"
            })
            .when("/LibraryUser", {
                templateUrl: "template/LibraryUser.html",
                controller: "LibraryUserController"
            })
            .when("/LateFeeDetails", {
                templateUrl: "template/LateFeeDetails.html",
                controller: "LateFeeDetailController"
            })
            .when("/IssueType", {
                templateUrl: "template/IssueType.html",
                controller: "IssueTypeController"
            })
            .when("/BookType", {
                templateUrl: "template/BookType.html",
                controller: "BookTypeController"
            })
            .when("/BooksCategory", {
                templateUrl: "template/BooksCategory.html",
                controller: "BooksCategoryController"
            })
            .when("/Books", {
                templateUrl: "template/Books.html",
                controller: "BooksController"
            })
            .when("/BookIssueStatus", {
                templateUrl: "template/BookIssueStatus.html",
                controller: "BookIssueStatusController"
            })
            .when("/BookIssued", {
                templateUrl: "template/BookIssued.html",
                controller: "BookIssuedController"
            })
            .when("/ESD", {
                templateUrl: "template/ESD.html",
                controller: "ESDController"
            })
            .when("/TheMain", {
                templateUrl: "template/TheMain.html",
                controller: "TheMainController"
            }).otherwise({
                redirectTo: "/TheMain"
            });
        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
        $locationProvider.hashPrefix('');
    });
})();