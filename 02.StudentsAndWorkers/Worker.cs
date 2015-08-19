namespace _02.StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int numberOfWorkDays = 5;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be more than 0");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be more than 0");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = (this.WeekSalary / numberOfWorkDays) / (this.WorkHoursPerDay);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, Money per hour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
