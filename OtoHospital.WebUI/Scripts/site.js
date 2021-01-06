let hiddenBsClass = "hidden";
let addCustomerToCarFormDiv = $("#addCustomerToCarFormDiv");
let newAppointmentFormDiv = $("#newAppointmentFormDiv");
let newWorkOrderFormDiv = $("#newWorkOrderFormDiv");
let newAppointmentBtn = $(".newAppointment");
let newWorkOrderBtn = $(".newWorkOrder");
let createCarBtn = $("#createCar");
createCarBtn.click(function () {

    if (addCustomerToCarFormDiv.hasClass(hiddenBsClass)) {
        addCustomerToCarFormDiv.removeClass(hiddenBsClass);

    } else {
        addCustomerToCarFormDiv.addClass(hiddenBsClass);
    }
});
newAppointmentBtn.click(function () {
    openCloseNewWorkOrderForm(false);
    openCloseNewAppointmentForm();

    let carId = $(this).data('id');
    let carPlaque = $(this).data('plaque');
    $("#newAppointmentFormDiv form #CarId").val(carId);
    $("#newAppointmentFormDiv form #CarPlaque").val(carPlaque);
});

newWorkOrderBtn.click(function () {
    openCloseNewAppointmentForm(false);
    openCloseNewWorkOrderForm();
    let carId = $(this).data('id');
    let carPlaque = $(this).data('plaque');
    $("#newWorkOrderFormDiv form #CarId").val(carId);
    $("#newWorkOrderFormDiv form #CarPlaque").val(carPlaque);
});

openCloseNewAppointmentForm = (open = true) => {
    if (open) {
        newAppointmentFormDiv.removeClass(hiddenBsClass);
    } else {
        newAppointmentFormDiv.addClass(hiddenBsClass);
    }
}
openCloseNewWorkOrderForm = (open = true) => {
    if (open) {
        newWorkOrderFormDiv.removeClass(hiddenBsClass);
    } else {
        newWorkOrderFormDiv.addClass(hiddenBsClass);
    }
}
