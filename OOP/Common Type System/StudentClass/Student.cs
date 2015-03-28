using System;

namespace StudentClass
{
    using System;
    using StudentClass.Enumerations;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long ssn;
        private string address;
        private string mobile;
        private string email;
        private int course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, long ssn, string address, string mobile, string email, int course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.lastName = value;
            }
        }

        public long Ssn
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.address = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.mobile = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.course = value;
            }
        }

        public Speciality Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                this.speciality = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (this.Address.Equals((obj as Student).Address) &&
                this.Course.Equals((obj as Student).Course) &&
                this.Email.Equals((obj as Student).Email) &&
                this.Faculty.Equals((obj as Student).Faculty) &&
                this.FirstName.Equals((obj as Student).FirstName) &&
                this.LastName.Equals((obj as Student).LastName) &&
                this.MiddleName.Equals((obj as Student).MiddleName) &&
                this.Mobile.Equals((obj as Student).Mobile) &&
                this.Speciality.Equals((obj as Student).Speciality) &&
                this.Ssn.Equals((obj as Student).Ssn) &&
                this.University.Equals((obj as Student).University))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}\nSsn: {3}\nAddress: {4}\nMobile: {5}\nEmail: {6}\nCourse: {7}\nSpeciality: {8}\nUniversity: {9}\nFaculty: {10}",
                this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.Mobile, this.Email, this.Course, this.Speciality, this.University, this.Faculty);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((firstName != null) ? this.firstName.GetHashCode() : 0);
                result = result * 23 + ((middleName != null) ? this.middleName.GetHashCode() : 0);
                result = result * 23 + ((lastName != null) ? this.lastName.GetHashCode() : 0);
                result = result * 23 + this.ssn.GetHashCode();
                result = result * 23 + ((address != null) ? this.address.GetHashCode() : 0);
                result = result * 23 + ((mobile != null) ? this.mobile.GetHashCode() : 0);
                result = result * 23 + ((email != null) ? this.email.GetHashCode() : 0);
                result = result * 23 + this.course.GetHashCode();
                result = result * 23 + this.speciality.GetHashCode();
                result = result * 23 + this.university.GetHashCode();
                result = result * 23 + this.faculty.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public object Clone() // Problem 2
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.Mobile, this.Email, this.Course, this.Speciality, this.University, this.Faculty);
        }

        public int CompareTo(Student other) // Problem 3
        {
            var nameOfStudent = this.FirstName + this.MiddleName + this.LastName;
            var nameOfOther = other.FirstName + other.MiddleName + other.LastName;

            if (nameOfStudent == nameOfOther)
            {
                return this.Ssn.CompareTo(other.Ssn); // Take another criteria that should be equal if the names are equal
            }

            return nameOfStudent.CompareTo(nameOfOther);
        }
    }
}