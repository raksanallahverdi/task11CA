
using System;
namespace Task7
{


    public static class Program
    {
        public static void Main()
        {
            User newUser = new User("Raksana", "Allahverdiyeva", "AKDF123", RegistrationMonth.January);
            newUser.GetDetails();
            User newUser2 = new User("Mammad", "Allahverdiyev", "555sdjo", RegistrationMonth.March);
            newUser2.GetDetails();
            User newUser3= new User("Samira", "Allahverdiyeva", "KRA7898", RegistrationMonth.January);
            newUser3.GetDetails();
            User newUser4 = new User("Aytac", "Allahverdiyeva", "1234UjY", RegistrationMonth.April);
            newUser4.GetDetails();
            User newUser5 = new User("Sevinc", "Allahverdiyeva", "6111MVM", RegistrationMonth.December);
            newUser5.GetDetails();
        }
    }

}

