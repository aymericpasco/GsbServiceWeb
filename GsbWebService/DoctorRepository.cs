using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GsbWebService
{
    public class DoctorRepository
    {

        public void Insert(DoctorEntity doctorEntity)
        {
            gsbEntities context = new gsbEntities();
            doctors doctor = new doctors();

            doctor.firstname = doctorEntity.FirstName;
            doctor.lastname = doctorEntity.LastName;
            doctor.address = doctorEntity.Address;
            doctor.phone = doctorEntity.Phone;
            doctor.specialty = doctorEntity.Specialty;
            doctor.department = doctorEntity.Department;

            context.doctors.Add(doctor);
            context.SaveChanges();
        }

        public IList<DoctorEntity> Select()
        {
            gsbEntities context = new gsbEntities();

            IList<DoctorEntity> listDoctorsEntity = new List<DoctorEntity>();

            IList<doctors> docs = (from n in context.doctors select n).ToList();

            DoctorEntity doctorEntity = null;

            foreach (doctors doc in docs)
            {
                doctorEntity = new DoctorEntity();
                doctorEntity.Id = doc.id;
                doctorEntity.FirstName = doc.firstname;
                doctorEntity.LastName = doc.lastname;
                doctorEntity.Address = doc.address;
                doctorEntity.Phone = doc.phone;
                doctorEntity.Specialty = doc.specialty;
                doctorEntity.Department = doc.department;

                listDoctorsEntity.Add(doctorEntity);
            }

            return listDoctorsEntity;
        }


    }
}