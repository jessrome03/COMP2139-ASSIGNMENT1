@model YourNamespace.ViewModels.BookingViewModel

<form method="post" action="@Url.Action("Book")">
    <!-- Add form fields for booking details (e.g., date, passenger names, etc.) -->
    <input type="text" name="Date" placeholder="Select Date" />
    <!-- Add other input fields -->

    <button type="submit">Confirm Booking</button>
</form>
