using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : ICloneable, IComparable
    {
        #region Enum
        public enum _University
        {
            SU,
            TU,
            UASG,
            UNSS            
        }
        public enum _Faculty
        {
            Mathematics,
            Economy,
            Physics,
            Informatics,
            StructuralEngeneering
        }
        public enum _Specialty
        {
            Informatics,
            Mathematics,
            Physics,
            Economics,
            CivilEngineering
        }
        #endregion

        #region Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public _University University { get; set; }
        public _Faculty Faculty { get; set; }
        public _Specialty Specialty { get; set; }
        #endregion

        #region Constructors
        public Student(string fName, string mName, string lName, string ssn,
                       string address, string phone, string email, int course,
                       _University university, _Faculty faculty, _Specialty specialty)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }
        #endregion        

        #region Methos
        public override bool Equals(object obj) //problem 1
        {
            var otherStudent = obj as Student;
            
            if (!this.FirstName.Equals(otherStudent.FirstName)) return false;
            if (!this.MiddleName.Equals(otherStudent.MiddleName)) return false;
            if (!this.LastName.Equals(otherStudent.LastName)) return false;
            if (!this.SSN.Equals(otherStudent.SSN)) return false;
            if (!this.Phone.Equals(otherStudent.Phone)) return false;
            if (!this.Address.Equals(otherStudent.Address)) return false;
            if (!this.Email.Equals(otherStudent.Email)) return false;
            if (!this.Faculty.Equals(otherStudent.Faculty)) return false;
            if (!this.Course.Equals(otherStudent.Course)) return false;
            if (!this.University.Equals(otherStudent.University)) return false;
            if (!this.Specialty.Equals(otherStudent.Specialty)) return false;
            
            return true;
        }

        public static bool operator ==(Student s1, Student s2) //problem 1
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Student s1, Student s2) //problem 1
        {
            return !(s1.Equals(s2));
        }

        public override string ToString() //problem 1
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("SSN: {0}", this.SSN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Phone: {0}", this.Phone));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("University: {0} Faculty: {1} Specialty: {2} Course {3}",
            this.University, this.Faculty, this.Specialty, this.Course));
            return result.ToString();
        }
        public override int GetHashCode() //problem 1
        {
            int hash = 13;
            hash = (hash * 17) + this.SSN.GetHashCode();
            hash = (hash * 19) + this.Course.GetHashCode();
            return hash;
        }

        public object Clone() //problem 2
        {
            Student temp = new Student(this.FirstName, this.MiddleName,
            this.LastName, this.SSN, this.Address, this.Phone, this.Email, this.Course, this.University, this.Faculty, this.Specialty);
            return temp;
        }

        public int CompareTo(object obj) //problem 3
        {
            var otherStudent = obj as Student;
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }
            if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }
            if (this.LastName.CompareTo(otherStudent.LastName) != 0)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            if (this.SSN.CompareTo(otherStudent.SSN) != 0)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
            return 0;
        }
        #endregion
    }
}
