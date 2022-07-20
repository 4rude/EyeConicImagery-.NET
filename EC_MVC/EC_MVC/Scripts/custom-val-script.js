$(document).ready(function () {
    $("#validate-this-form").validate({
        errorClass: "valError",
        rules: {
            firstName: {
                required: true
            },

            lastName: {
                required: true
            },

            date: {
                required: true,
                date: true
            },

            email: {
                required: true,
                email: true
            },

            confirmation: {
                required: true,
                email: true
            },

            subject: {
                required: true
            },

            message: {
                required: true
            }
        },

        message: {
            firstName: "The first name field is required.",
            lastName: "The last name field is required.",
            date: "The date field is required.",
            email: "A valid email field is required.",
            confirmation: "A valid email field is required.",
            subject: "The subject line is required",
            message: "The message field is required."
        },

        submitHandler: function (form) {
            // alert('valid form');
            return false;
        }
    });
});