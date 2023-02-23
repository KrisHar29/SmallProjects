// Purpose of this is to return number of weeks with remainder days
// 

using RetirementCalculator;
using System.Diagnostics;

DateTime kris = new DateTime(2023, 02, 23);
DateTime retirementAge = kris.AddYears(67);
int test = DaysUntilRetirementAge(retirementAge);
Console.WriteLine(test.ToString());
RetireModel testOutput = NumberOfWeeksAndDaysUntilRetirement(retirementAge, 25);
Console.WriteLine($"Retirement date = {testOutput.RetirementAge.ToLongDateString()}.\nYearly holidays = {testOutput.YearlyHolidays}.\nAfter deducting holidays from working weeks you have\n{testOutput.NumberOfWeeks} weeks and {testOutput.NumberOfDays} days remaining until you can retire!");
Console.ReadLine();

static int DaysUntilRetirementAge(DateTime retirementAge)
{
    int days = retirementAge.Subtract(DateTime.Now).Days;
    days += 1;
    return days;
}

static int HolidayDaysUntilRetirementAge(DateTime retirementAge, int yearlyHolidays)
{
    int days = 0;
    return days;
}

static RetireModel NumberOfWeeksAndDaysUntilRetirement(DateTime retirementAge, int yearlyHolidays)
{
    int totalDaysLeft = DaysUntilRetirementAge(retirementAge);
    int totalHolidayDays = HolidayDaysUntilRetirementAge(retirementAge, yearlyHolidays);
    int numberOfWeeks = totalDaysLeft / 7;
    int remainingDays = totalDaysLeft % 7;
    int daysUntilTheWeekend = 0;
    int numberOfDays = 0;

    switch (DateTime.Now.DayOfWeek)
    {
        case DayOfWeek.Monday:
            daysUntilTheWeekend = 5;
            break;
        case DayOfWeek.Tuesday:
            daysUntilTheWeekend = 4;
            break;
        case DayOfWeek.Wednesday:
            daysUntilTheWeekend = 3;
            break;
        case DayOfWeek.Thursday:
            daysUntilTheWeekend = 2;
            break;
        case DayOfWeek.Friday:
            daysUntilTheWeekend = 1;
            break;
        case DayOfWeek.Saturday:
            daysUntilTheWeekend = 0;
            break;
        case DayOfWeek.Sunday:
            daysUntilTheWeekend = 0;
            break;
        default: break;
    }

    if (remainingDays >= daysUntilTheWeekend)
    {
        if ((remainingDays - 2) > daysUntilTheWeekend)
        {
            numberOfDays += (remainingDays - 2);
        }
        else { numberOfDays += daysUntilTheWeekend; }
    }

    double holidayDeductionWeeks = 0;
    holidayDeductionWeeks = (numberOfWeeks / 52.143) * (yearlyHolidays / 5);
    numberOfWeeks -= Convert.ToInt32(holidayDeductionWeeks);
    
    double holidayDeductionDays = holidayDeductionWeeks - Math.Truncate(holidayDeductionWeeks);
    holidayDeductionDays = holidayDeductionDays*5;
    if (Convert.ToInt32(holidayDeductionDays) - numberOfDays >= 0)
    {
        numberOfDays = Convert.ToInt32(holidayDeductionDays) - numberOfDays;
    }
    else
    {
        numberOfWeeks -= 1;
        numberOfDays = Convert.ToInt32(holidayDeductionDays) + 5 - numberOfDays;
    }

    RetireModel output = new RetireModel();
    output.YearlyHolidays = yearlyHolidays;
    output.NumberOfDays = numberOfDays;
    output.NumberOfWeeks = numberOfWeeks;
    output.RetirementAge = retirementAge;

    return output;
   }
