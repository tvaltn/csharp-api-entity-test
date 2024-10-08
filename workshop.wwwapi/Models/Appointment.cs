﻿using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    public enum AppointmentType
    {
        Online = 0,
        InPerson = 1
    }

    [Table("appointments")]
    public class Appointment
    {
        [Column("type")]
        public AppointmentType Type { get; set; }
        [Column("booking")]
        public DateTime Booking { get; set; }
        [ForeignKey("Doctor")]
        [Column("doctor_id")]
        public int DoctorId { get; set; }
        [ForeignKey("Patient")]
        [Column("patient_id")]
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
