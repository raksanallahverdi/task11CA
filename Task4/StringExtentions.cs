
namespace Task4;

public static class StringExtentions
{

    public static void FindAge(this DateTime userTime)
    {
        DateTime dateTimeNow = DateTime.Now;
        int nowMonth = dateTimeNow.Month;
        int nowYear = dateTimeNow.Year;
        int nowDay = dateTimeNow.Day;
        int userMonth = userTime.Month;
        int userYear = userTime.Year;
        int userDay = userTime.Day;
        int birthday = 0;

        if (userMonth - nowMonth < 0)
            birthday = nowYear - userYear;
        else if (userMonth - nowMonth > 0)
            birthday = nowYear - userYear - 1;
        else
        {
            if (userDay - nowDay <= 0)
                birthday = nowYear - userYear;
            else
                birthday = nowYear - userYear - 1;
        }

        Console.WriteLine(birthday);
    }
}

