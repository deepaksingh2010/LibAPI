/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");

    var logService = function () {
        var factory = {};
        factory.LogError = function (error,type) {
            switch (type) {
                case type = "I": {
                    console.log("Information!");
                    console.log(error);
                    break;
                }
                default: {
                    console.log("Error!");
                    console.log(error);
                }
            }
        }
        return factory;
    };
    pnsrlibrary.factory("logService", logService);
})();