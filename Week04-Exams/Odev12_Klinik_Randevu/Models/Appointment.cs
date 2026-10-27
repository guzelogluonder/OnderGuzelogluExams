using System;
using System.Xml;

namespace Odev12_Klinik_Randevu.Models;

public class Appointment
{
    public int Id { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public string DoctorName { get; set; } = string.Empty;
    public string TimeSlot { get; set; } = string.Empty;
    public bool IsCancelled { get; set; }
    public Appointment(int id, string patientName, string doctorName, string timeSlot, bool isCancelled)
    {
        Id = id;
        PatientName = patientName;
        DoctorName = doctorName;
        TimeSlot = timeSlot;
        IsCancelled = isCancelled;
    }

    public void Display()
    {
        string status = string.Empty;
        if (IsCancelled)
        {
            status = "Iptal";
        }
        else
        {
            status = "Aktif";
        }
        System.Console.WriteLine($"[{Id}] {TimeSlot} — {PatientName} / Dr. {DoctorName} ({status})");
    }
}
