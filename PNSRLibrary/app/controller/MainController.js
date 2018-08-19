(function () {
    var pnsrlibrary = angular.module("pnsrlibrary");

    var MainContoller = function ($scope, $location, $interval) {
        // create a message to display in our view
        $scope.check = true;
        $scope.toggleclick = function (check) {
            if (check == true) {
                $scope.check = false;
            }
            else {
                $scope.check = true;
            }
        }

    };
    pnsrlibrary.controller("MainContoller", ["$scope", "$location", "$interval", MainContoller]);
})();