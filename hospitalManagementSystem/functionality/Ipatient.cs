using Hospital_Management_System.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.functionality
{
    public interface Ipatient
    {

        void dental();
        void generalMedicine();
        void orthopedic();
        void search(int n);
        void deleteData(int n);
        void updateData(int n);
        IEnumerable<patientRegistration> GetData();
        int createData(patientRegistration p);
    }
}
