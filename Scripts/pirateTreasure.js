angular.module('pirateTreasure', [])
	.controller('myController', ['$scope', '$http', function ($scope, $http) {
	    $scope.loading = true;
	    $scope.getCoins = function () {
	        $scope.loading = false;
	        var url = "api/Pirate/" + $scope.numberOfPirates;
	        $http.get(url).success(function (data, status, headers, config) {
	            $scope.loading = true;
	            $scope.numberOfCoins = data;
	        })
				.error(function (data, status, headers, config) {
				    $scope.loading = true;
				    alert("Incorrect Input");
				    $scope.numberOfCoins = null;
				});
	    };
	} ]);