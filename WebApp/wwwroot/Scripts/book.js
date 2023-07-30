angular.module('myApp', ['ngMaterial'])
    .controller('myController', function ($scope, $http, $window) {
       
        console.log('Your UUID is: ' + uuidv4());
        $scope.booking = {}; // Initialize the booking object to store form data
        $scope.errors = {}; // Initialize the errors object to store validation errors
        $scope.dropdownItems = [];
        $scope.paymentmethod = paymentMethods;
        function populateDropdown() {
            $http.get("/Booking/GetPhoneList") // Replace with the actual URL of your HTTP GET service
                .then(function (response) {
                    // On success, populate the dropdown with data received from the service
                    $scope.dropdownItems = response.data;
                }, function (error) {
                    // Handle error if needed
                    
                });
        }

        function uuidv4() {
            return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'
                .replace(/[xy]/g, function (c) {
                    const r = Math.random() * 16 | 0,
                        v = c == 'x' ? r : (r & 0x3 | 0x8);
                    return v.toString(16);
                });
        }

        // Call the function to populate the dropdown on page load
        populateDropdown();

        $scope.submitForm = function () {
            // Perform any client-side validation here if needed
            // ...
            $scope.booking.BookingId = uuidv4();
            $scope.booking.AvailableDateForCollection = $scope.booking.AvailableDateForCollection.toISOString();
            // Post the data to the server using $http
            $http( {
                method: 'POST',
                url: '/Booking/Book',
                data: $.param($scope.booking),
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                })
                .then(function (response) {
                    // Handle success response if needed
                    if (response.data.code==0) {
                        // Perform the client-side redirect
                        var queryParams = $.param(response.data);
                        $window.location.href = "BookingConfirmation?" + queryParams;
                    }
                    console.log(response.data);
                }, function (error) {
                    // Handle error response if needed
                    

                    // Set the errors object based on the server's validation response
                    if (error.data ) {
                        $scope.errors = error.data;
                    }
                });
        };
    });