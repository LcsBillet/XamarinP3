using System;
using System.Collections.Generic;
using System.Text;

namespace profil
{

    public enum Gender
    {
        Garçon,
        Fille,
    }
    public partial class PersoInf
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public PersoInf(string firstname, string lastname, DateTime birthdate, Gender gender)
        {
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthdate;
            Gender = gender;
        }
    }

    public class Rate
    {
        public float morningSlow { get; set; }
        public float morningFast { get; set; }
        public float lunchSlow { get; set; }
        public float lunchFast { get; set; }
        public float snackSlow { get; set; }
        public float snackFast { get; set; }
        public float eveningSlow { get; set; }
        public float eveningFast { get; set; }

        public Rate(float morningslow, float morningfast, float lunchslow, float lunchfast, float snackslow, float snackfast, float eveningslow, float eveningfast)
        {
            morningSlow = morningslow;
            morningFast = morningfast;
            lunchSlow = lunchSlow;
            lunchFast = lunchfast;
            snackSlow = snackslow;
            snackFast = snackfast;
            eveningSlow = eveningslow;
            eveningFast = eveningfast;
        }
    }
}