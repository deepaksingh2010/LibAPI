/// <reference path="D:\Dev Deepak\LibAPI\PNSRLibrary\Scripts/angular.js" />
(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");
    pnsrlibrary.directive('watermarkText', function ($timeout) {
        return {
            restrict: 'A',
            require: 'ngModel',
            link: function (scope, element, attr, ctrl) {
                $timeout(function () {
                    var onFocus = function () {
                        if (element.val() === attr.watermarkText) {
                            element.val("");
                        }
                        element.removeClass('watermark');
                    };

                    var onBlur = function () {

                        if (element.val() === "") {
                            element.val(attr.watermarkText);
                            element.addClass('watermark');
                        }
                    };

                    if (attr.readonly !== true) {
                        element.bind('focus', onFocus);
                        element.bind('blur', onBlur);
                        element.triggerHandler('blur');
                    }

                    scope.$watch(attr.ngModel, function (v) {
                        onFocus();
                        onBlur();
                    });

                });
            }
        };
    });    
})();