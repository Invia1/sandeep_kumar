using Hospital_Management_System.models;
using System;


namespace Hospital_Management_System.functionalities
{
    internal interface Ipatient
    {
        public int createData(PatientRegistration p);
        public List<PatientRegistration> GetData();
        void Search(int n);
        void DeleteData(int n);
       void UpdateData(int n);
        void generalMedicine();
        void orthopedic();
        void Dental();
    }
}
