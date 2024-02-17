using System;

namespace lab_1.Models
{
    [Serializable]
    public class StudentVm
    {
        public String Name;
        public String Surname;
        public String Adress;
        public String Phonenumber;
        public StudentVm(String name, String surname, String adress, String phonenumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
            this.Phonenumber = phonenumber;
        }
    }
}
