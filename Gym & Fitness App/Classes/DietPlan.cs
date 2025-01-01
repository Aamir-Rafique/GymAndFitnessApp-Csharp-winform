namespace Gym___Fitness_App
{
    public class DietPlan
    {
        public int UserID { get; set; } // Foreign key
        public string MealTime { get; set; }
        public int FoodItem { get; set; }
        public string Notes { get; set; }
    }
}
