app.directive("dateMask", ["$filter", function ($filter) {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModelController) {

            //View -> Model
            ngModelController.$parsers.push(function (data) {
                console.log(data);
                return $filter('date')(data, "yyyy-MM-dd");
            });

            //Model -> View
            ngModelController.$formatters.push(function (data) {
                element.mask("99/99/9999", { });
                return $filter('date')(data, "dd/MM/yyyy");
            });
        }
    }
}]);

app.directive("phoneMask", function () {
    return {
        require: '?ngModel',
        link: function ($scope, element, attrs, controller) {
            element.mask("(99) 9999-9999", {
                completed: function () {
                    $scope.$apply();
                }
            });
        }
    };
});

app.directive("cpfMask", function () {
    return {
        require: '?ngModel',
        link: function ($scope, element, attrs, controller) {
            element.mask("999.999.999-99", {
                completed: function () {
                    $scope.$apply();
                }
            });
        }
    };
});

app.directive("cepMask", function () {
    return {
        require: '?ngModel',
        link: function ($scope, element, attrs, controller) {
            element.mask("99999-999", {
                completed: function () {
                    $scope.$apply();
                }
            });
        }
    };
});

app.directive("cnpjMask", function () {
    return {
        require: '?ngModel',
        link: function ($scope, element, attrs, controller) {
            element.mask("99.999.999/9999-99", {
                completed: function () {
                    $scope.$apply();
                }
            });
        }
    };
});