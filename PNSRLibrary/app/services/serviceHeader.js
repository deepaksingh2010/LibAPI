/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");

    var serviceHeader = function () {
        var factory = {};
        factory.GetServiceHeader = function (type) {
            switch (type) {
                case type ="HeaderJsonConfig": {
                    var config = {
                        headers: {
                            'Content-Type': 'Text/Json'
                        }
                    }
                    return config;
                }
                default: {
                    var config = {
                        headers: {
                            'Content-Type': 'Text/Json'
                        }
                    }
                    return config;
                }
            }
        }
        return factory;
    };
    pnsrlibrary.factory("serviceHeader", serviceHeader);
})();