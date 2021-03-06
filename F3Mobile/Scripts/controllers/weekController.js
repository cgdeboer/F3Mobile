﻿(function () {
    var injectParams = ["calendarService", "regionService", "$rootScope", "_", '$route'];

    var weekController = function (calendarService, regionService, $rootScope, _, $route) {
        var vm = this,
            dayOfWeek = [{ 'val': 0, "day": 'Monday' }, { 'val': 1, "day": 'Tuesday' }, { 'val': 2, "day": 'Wednesday' }, { 'val': 3, "day": 'Thursday' }, { 'val': 4, "day": 'Friday' }, { 'val': 5, "day": 'Saturday' }, { 'val': 6, "day": 'Sunday' }];

        vm.thisweek = [];

        $rootScope.regions = regionService.regions;
        $rootScope.region = $rootScope.regions[0];
        $rootScope.$route = $route;

        $rootScope.showRegion = true;

        vm.selectedRegion = '';

        $rootScope.setSelected = function () {
            vm.selectedRegion = $rootScope.region.val;
        };

        $rootScope.title = "Schedule";



        var x = calendarService.getWeek();

        x.$loaded()
            .then(function (x) {
                displayEvents(x);
            });

        x.$watch(function (event) {
            displayEvents(x);
        });

        function displayEvents(x) {
            angular.forEach(x, function (item, i) {
                item.Day = moment(item.Start).format("dddd");
                item.DayOfMonth = moment(item.Start).format("D");
                item.DayOfYear = moment(item.Start).format("DDD");
                item.DayNumber = _.findWhere(dayOfWeek, { day: item.Day }).val;
            });
            var grpd = _.groupBy(x, 'DayOfYear');
            var mapped = _.map(grpd, function (item, key) {
                return {
                    DayOfYear: key,
                    DayOfMonth: key,
                    Day: item[0].Day,
                    Items: item,
                    Date: item.length > 0 ? moment(item[0].Start).format('MM/DD/YYYY') : '',
                };
            });
            vm.items = mapped;
        }

    };

    weekController.$inject = injectParams;
    angular.module('ScheduleApp').controller('WeekController', weekController);
}());