using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.TimeOfDay.TotalHours >= 12;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString()}.";

    public static DateTime AnniversaryDate()
    {
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
