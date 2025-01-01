namespace Gym___Fitness_App
{
    public class WorkoutPlan
    {
        public int UserID { get; set; } // Foreign key
        public string Day { get; set; }
        public string Workout { get; set; }
        public string Duration { get; set; }
        public string Intensity { get; set; }
    }
}
