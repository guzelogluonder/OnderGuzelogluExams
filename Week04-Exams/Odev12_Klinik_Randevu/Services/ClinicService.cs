using System;
using Odev12_Klinik_Randevu.Models;

namespace Odev12_Klinik_Randevu.Services;

public class ClinicService
{
    private List<Appointment> _appointments = [];
    private Dictionary<int, Appointment> _dictAppointment = [];
    private int _nextAppointmentId = 1;

    public void AddAppointment(string patientName, string doctorName, string timeSlot)
    {
        if (string.IsNullOrWhiteSpace(patientName))
        {
            Console.WriteLine("[HATA:] Ad boş olamaz!");
            return;
        }
        if (string.IsNullOrWhiteSpace(doctorName))
        {
            Console.WriteLine("[HATA:] Soyad boş olamaz!");
            return;
        }

        Appointment appointment = new Appointment(_nextAppointmentId++, patientName, doctorName, DateTime.Today.ToString(), false);
        _appointments.Add(appointment);
        _dictAppointment[appointment.Id] = appointment;
    }

    public void ListAppointment()
    {
        System.Console.WriteLine("--- Randevu Listesi ---");
        if (_appointments.Count == 0)
        {
            Console.WriteLine("Kayıtlı Randevu yok!");
            return;
        }
        else
        {
            foreach (Appointment appointment in _appointments)
            {
                appointment.Display();
            }
        }

    }

    public void CancelAppointment(int id)
    {
        if (_dictAppointment.TryGetValue(id, out Appointment? appointment))
        {
            if (appointment.IsCancelled != true)
            {
                appointment.IsCancelled = true;
            }
            else
            {
                System.Console.WriteLine("Bu başvuru daha önce iptal edilmiş.");
            }
        }
        else
        {
            System.Console.WriteLine("Id'ye ait randevu bulunamadı.");
        }
    }
    public int GetActiveCount()
    {
        int count = 0;
        foreach (Appointment appointment in _appointments)
        {
            if (appointment.IsCancelled == false)
            {
                count++;
            }
        }
        return count;
    }

}
