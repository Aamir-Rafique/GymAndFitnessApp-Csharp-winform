using System.Collections.Generic;

namespace GymAndFitness
{
    public class User
    {
        public int UserID { get; set; } //primary key
        public List<WorkoutPlan> WorkoutPlans { get; set; }
        public List<DietPlan> DietPlans { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double StartingWeight { get; set; }
        public double CurrentWeight { get; set; }
        public double BMI { get; set; }
        public string TargetWeightRange { get; set; }
        public double TargetWeight { get; set; }
        public string FitnessGoal { get; set; }
        public string FitnessLevel { get; set; }
        public byte[] ProfilePicture { get; set; }
        public double DailyWaterIntake { get; set; }
        public string MembershipStatus { get; set; }
        public string LicenseKey { get; set; }

        public User()
        {
            DietPlans = new List<DietPlan>();
            WorkoutPlans = new List<WorkoutPlan>();
        }

    }

}
