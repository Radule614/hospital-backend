﻿using HospitalLibrary.Core.Model;
using HospitalLibrary.Core.Repository;
using HospitalLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Core.Service
{
    public class PhysicianScheduleService : IPhysicianScheduleService
    {
        private readonly IPhysicianScheduleRepository _physicianScheduleRepository;
        private readonly IAppointmentRepository _appointmentRepository;

        public PhysicianScheduleService(IPhysicianScheduleRepository physicianScheduleRepository, IAppointmentRepository appointmentRepository)
        {
            _physicianScheduleRepository = physicianScheduleRepository;
            _appointmentRepository = appointmentRepository;
        }

        public void Create(PhysicianSchedule physicianSchedule)
        {
            _physicianScheduleRepository.Create(physicianSchedule);
        }

        public void Delete(PhysicianSchedule physicianSchedule)
        {
            _physicianScheduleRepository.Delete(physicianSchedule);
        }

        public IEnumerable<PhysicianSchedule> GetAll()
        {
            return _physicianScheduleRepository.GetAll();
        }

        public List<Appointment> GetAvailableAppointments(int doctorId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public PhysicianSchedule GetById(int id)
        {
            return _physicianScheduleRepository.GetById(id);
        }

        public PhysicianSchedule Get(int doctorId)
        {
            foreach (var physicianSchedule in _physicianScheduleRepository.GetAll())
            {
                if (physicianSchedule.DoctorId == doctorId)
                {
                    return physicianSchedule;
                }
            }

            return null;
        }

        public List<Appointment> GetAppointments(int doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach (var physicianSchedule in _physicianScheduleRepository.GetAll())
            {
                if (physicianSchedule.DoctorId == doctorId)
                {
                    foreach (var appointment in physicianSchedule.Appointments)
                    {
                        if (!appointment.IsFinished)
                        {
                            appointments.Add(appointment);
                        }
                    }
                }
            }

            return appointments;
        }

        public bool Schedule(int doctorId, Appointment appointment)
        {
            PhysicianSchedule physicianSchedule = _physicianScheduleRepository.Get(doctorId);
            if (physicianSchedule.IsAppointmentValid(appointment))
            {
                physicianSchedule.Appointments.Add(appointment);
                Update(physicianSchedule);
                return true;
            }

            return false;
        }

        public void TransferAppointment(int doctorId, Appointment appointment)
        {
            PhysicianSchedule physicianSchedule = _physicianScheduleRepository.Get(doctorId);
            physicianSchedule.Appointments.Add(appointment);
            _physicianScheduleRepository.Update(physicianSchedule);
        }

        public void Update(PhysicianSchedule physicianSchedule)
        {
            _physicianScheduleRepository.Update(physicianSchedule);
        }

        public void SetAppointmentToFinish(int appointmentId)
        {
            Appointment appointment = _appointmentRepository.GetById(appointmentId);
            appointment.IsFinished = true;
            _appointmentRepository.Update(appointment);
        }
    }
}
