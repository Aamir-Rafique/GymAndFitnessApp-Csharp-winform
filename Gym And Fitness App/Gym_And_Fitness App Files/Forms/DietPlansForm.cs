using GymAndFitness.Forms;
using Newtonsoft.Json.Linq; // Newtonsoft.Json for api integration
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAndFitness
{
    public partial class DietPlansForm : BaseForm
    {
        private static DietPlansForm instance;
        private DietPlansForm()
        {
            InitializeComponent();
        }
        public static DietPlansForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DietPlansForm();
            }
            return instance;
        }

        UserDataManager userDataManager = new UserDataManager();  //Instanse of the class: (userDataManager)

        //LOAD
        private void DietPlansForm_Load(object sender, EventArgs e)
        {

            //Dietpics
            timerForPics.Start();

            //  accessing current user 
            if (UserDataManager.CurrentUser != null)
            {
                userDataManager.ApplyProfilePicture(btnProfilePicture);
                //load membership plan pics
                pbMembershipStatus.Image = Features.MembershipStatusPic();

                //database...
                int userId = UserDataManager.CurrentUser.UserID;
                // Replace with actual logic to get the current user ID
                userDataManager.LoadDietPlans(userId, lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput, richTextBoxNotesInput);

                //allign centere cmb box items
                Features.AlignComboBoxTextCenter(cmbDietType);

                //disabling online food search feature for free members... 
                if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
                {
                    rbtnOnline.BackColor = Color.Gainsboro;
                    rbtnOnline.ForeColor = Color.Gray;
                }
            }

            txtFoodItem.Text = "Type here";
            txtFoodItem.ForeColor = Color.Gray;
        }



        //Diet types  recipes

        private void cmbDietType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedDietType = cmbDietType.SelectedItem.ToString();
            LoadDietPlans(selectedDietType);
            pbDiet.Visible = false;
        }

        private void LoadDietPlans(string dietType)
        {
            pnlDietPlans.Controls.Clear();
            List<DietPlan> dietPlans = GetDietPlans(dietType);
            int yOffset = 10;

            foreach (DietPlan dietPlan in dietPlans)
            {
                Label lblDietName = new Label
                {
                    Text = dietPlan.Name,
                    Location = new Point(10, yOffset),
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic)
                };

                Label lblRecipe = new Label
                {
                    Text = dietPlan.Recipe,
                    Location = new Point(20, yOffset + 20),
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Regular)
                };

                PictureBox picMeal = new PictureBox
                {
                    Image = dietPlan.Image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(500, 280),
                    Location = new Point(50, yOffset + 115)
                };

                pnlDietPlans.Controls.Add(lblDietName);
                pnlDietPlans.Controls.Add(lblRecipe);
                pnlDietPlans.Controls.Add(picMeal);

                yOffset += 420;
            }
        }


        private List<DietPlan> GetDietPlans(string dietType)
        {
            List<DietPlan> dietPlans = new List<DietPlan>();

            if (dietType == "Weight Loss")
            {
                dietPlans.Add(new DietPlan
                {
                    Name = "1. Grilled Chicken Salad",
                    Recipe = "- Grilled chicken breast\n- Lettuce, spinach, and kale\n- Cherry tomatoes and cucumbers\n- Olive oil and lemon dressing",
                    Image = Properties.Resources.Grilled_Chicken_Salad
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "2. Oatmeal with Fruits",
                    Recipe = "- Rolled oats\n- Almond milk\n- Sliced bananas and berries\n- A drizzle of honey",
                    Image = Properties.Resources.Oatmeal_with_Fruits
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "3. Quinoa Bowl",
                    Recipe = "- Cooked quinoa\n- Steamed broccoli\n- Sliced avocado\n- Grilled salmon",
                    Image = Properties.Resources.Quinoa_Bowl
                });
            }
            else if (dietType == "Muscle Gain")
            {
                dietPlans.Add(new DietPlan
                {
                    Name = "1. Chicken and Rice",
                    Recipe = "- Grilled chicken breast\n- Steamed brown rice\n- Steamed vegetables (broccoli, carrots)\n- Light soy sauce",
                    Image = Properties.Resources.Chicken_and_Rice
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "2. Protein Smoothie",
                    Recipe = "- Whey protein powder\n- Almond milk\n- Frozen berries\n- A spoonful of peanut butter",
                    Image = Properties.Resources.Protein_Smoothie
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "3. Egg and Sweet Potato",
                    Recipe = "- Scrambled eggs\n- Roasted sweet potatoes\n- Sautéed spinach\n- A sprinkle of paprika",
                    Image = Properties.Resources.Egg_and_Sweet_Potato
                });
            }
            else if (dietType == "Keto")
            {
                dietPlans.Add(new DietPlan
                {
                    Name = "1. Avocado Egg Salad",
                    Recipe = "- Hard-boiled eggs\n- Mashed avocado\n- Diced celery\n- A pinch of salt and pepper",
                    Image = Properties.Resources.Avocado_Egg_Salad
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "2. Zucchini Noodles with Pesto",
                    Recipe = "- Spiralized zucchini\n- Homemade pesto (basil, olive oil, pine nuts, garlic)\n- Grated Parmesan cheese",
                    Image = Properties.Resources.Zucchini_Noodles_with_Pesto
                });
                dietPlans.Add(new DietPlan
                {
                    Name = "3. Grilled Salmon with Asparagus",
                    Recipe = "- Grilled salmon fillet\n- Steamed asparagus\n- Lemon butter sauce",
                    Image = Properties.Resources.Grilled_Salmon_with_Asparagus
                });
            }

            return dietPlans;
        }

        class DietPlan
        {
            public string Name { get; set; }
            public string Recipe { get; set; }
            public Bitmap Image { get; set; }
        }


        //to display images afer some interval
        private int imageIndex = 0;

        private void timerForPics_Tick_1(object sender, EventArgs e)
        {

            Image[] workoutImages = {
            Properties.Resources.diet1,
            Properties.Resources.diet2,
            Properties.Resources.diet3,
            Properties.Resources.diet4,
            Properties.Resources.diet5,
            Properties.Resources.Diet_carbs,
            Properties.Resources.Diet_classification,
            Properties.Resources.Diet_FOod_pyramid,
            Properties.Resources.Diet_macronutrients,
            Properties.Resources.Diet_Protien,
            Properties.Resources.Diet_Protien1,
              };

            // Generate a random index
            Random random = new Random();
            imageIndex = random.Next(0, workoutImages.Length);


            // Set the current image
            pbDiet.Image = workoutImages[imageIndex];

            // Move to the next image
            imageIndex = (imageIndex + 1) % workoutImages.Length;
        }





        //Data for offline food search
        private Dictionary<string, string> nutritionData = new Dictionary<string, string>
        {
        // Fruits
            { "apple", "Calories: 52, Carbs: 14g, Protein: 0.3g, Fat: 0.2g" },
            { "banana", "Calories: 89, Carbs: 23g, Protein: 1.1g, Fat: 0.3g" },
            { "orange", "Calories: 62, Carbs: 15g, Protein: 1.2g, Fat: 0.2g" },
            { "grape", "Calories: 69, Carbs: 18g, Protein: 0.7g, Fat: 0.2g (per 100g)" },
            { "mango", "Calories: 60, Carbs: 15g, Protein: 0.8g, Fat: 0.4g" },
            { "pineapple", "Calories: 50, Carbs: 13g, Protein: 0.5g, Fat: 0.1g" },
            { "watermelon", "Calories: 30, Carbs: 8g, Protein: 0.6g, Fat: 0.2g" },
            { "pear", "Calories: 57, Carbs: 15g, Protein: 0.4g, Fat: 0.1g" },
            { "strawberries", "Calories: 32, Carbs: 7.7g, Protein: 0.7g, Fat: 0.3g" },
            { "blueberries", "Calories: 57, Carbs: 14g, Protein: 0.7g, Fat: 0.3g" },


             // Vegetables
            { "potato", "Calories: 77, Carbs: 17g, Protein: 2g, Fat: 0.1g" },
            { "tomato", "Calories: 18, Carbs: 3.9g, Protein: 0.9g, Fat: 0.2g" },
            { "broccoli", "Calories: 55, Carbs: 11g, Protein: 3.7g, Fat: 0.6g" },
            { "carrot", "Calories: 41, Carbs: 10g, Protein: 0.9g, Fat: 0.2g" },
            { "spinach", "Calories: 23, Carbs: 3.6g, Protein: 2.9g, Fat: 0.4g" },
            { "onion", "Calories: 40, Carbs: 9g, Protein: 1.1g, Fat: 0.1g" },
            { "bell pepper", "Calories: 31, Carbs: 6g, Protein: 1g, Fat: 0.3g" },
            { "zucchini", "Calories: 17, Carbs: 3.1g, Protein: 1.2g, Fat: 0.3g" },
            { "cucumber", "Calories: 15, Carbs: 3.6g, Protein: 0.7g, Fat: 0.1g" },
            { "corn", "Calories: 86, Carbs: 19g, Protein: 3.2g, Fat: 1.2g (per 100g)" },
            

            // Proteins
            { "chicken breast", "Calories: 165, Carbs: 0g, Protein: 31g, Fat: 3.6g" },
            { "egg", "Calories: 68, Carbs: 0.6g, Protein: 6g, Fat: 4.8g" },
            { "beef steak", "Calories: 271, Carbs: 0g, Protein: 25g, Fat: 19g" },
            { "salmon", "Calories: 208, Carbs: 0g, Protein: 20g, Fat: 13g" },
            { "tofu", "Calories: 144, Carbs: 3.9g, Protein: 15.7g, Fat: 8.1g (per 100g)" },
            { "lentils", "Calories: 116, Carbs: 20g, Protein: 9g, Fat: 0.4g (per 100g)" },
            { "chickpeas", "Calories: 164, Carbs: 27g, Protein: 9g, Fat: 2.6g (per 100g)" },
            { "shrimp", "Calories: 99, Carbs: 0.2g, Protein: 24g, Fat: 0.3g (per 100g)" },
            { "turkey breast", "Calories: 135, Carbs: 0g, Protein: 30g, Fat: 1g" },
           

            // Dairy
            { "milk", "Calories: 42, Carbs: 5g, Protein: 3.4g, Fat: 1g (per 100ml)" },
            { "cheese", "Calories: 402, Carbs: 1.3g, Protein: 25g, Fat: 33g" },
            { "yogurt", "Calories: 59, Carbs: 3.6g, Protein: 10g, Fat: 0.4g (per 100g)" },
            { "butter", "Calories: 717, Carbs: 0.1g, Protein: 0.9g, Fat: 81g" },
            { "cottage cheese", "Calories: 98, Carbs: 3.4g, Protein: 11g, Fat: 4.3g" },
           

             // Grains and Legumes
            { "rice", "Calories: 130, Carbs: 28g, Protein: 2.4g, Fat: 0.3g" },
            { "bread", "Calories: 265, Carbs: 49g, Protein: 9g, Fat: 3.2g" },
            { "pasta", "Calories: 131, Carbs: 25g, Protein: 5g, Fat: 1.1g" },
            { "quinoa", "Calories: 120, Carbs: 21g, Protein: 4g, Fat: 2g (per 100g)" },
            { "oats", "Calories: 389, Carbs: 66g, Protein: 17g, Fat: 7g" },



            // Nuts and Seeds
            { "almonds", "Calories: 576, Carbs: 21g, Protein: 21g, Fat: 49g" },
            { "walnuts", "Calories: 654, Carbs: 14g, Protein: 15g, Fat: 65g" },
            { "peanut butter", "Calories: 588, Carbs: 20g, Protein: 25g, Fat: 50g" },
            { "chia seeds", "Calories: 486, Carbs: 42g, Protein: 17g, Fat: 31g (per 100g)" },
            { "flaxseeds", "Calories: 534, Carbs: 29g, Protein: 18g, Fat: 42g" },

            // Oils and Fats
            { "olive oil", "Calories: 119, Carbs: 0g, Protein: 0g, Fat: 14g (per tablespoon)" },
            { "coconut oil", "Calories: 117, Carbs: 0g, Protein: 0g, Fat: 14g (per tablespoon)" },
        
            // Snacks
            { "popcorn", "Calories: 387, Carbs: 78g, Protein: 13g, Fat: 4.3g (per 100g)" },
            { "chocolate", "Calories: 546, Carbs: 61g, Protein: 4.9g, Fat: 31g (per 100g)" },


            // Pakistani Food
            { "biryani", "Calories: 290, Carbs: 34g, Protein: 15g, Fat: 10g (per serving)" },
            { "nihari", "Calories: 260, Carbs: 4g, Protein: 20g, Fat: 20g (per serving)" },
            { "haleem", "Calories: 315, Carbs: 40g, Protein: 20g, Fat: 10g (per serving)" },
            { "paratha", "Calories: 290, Carbs: 33g, Protein: 4g, Fat: 15g (per piece)" },
            { "chapli kebab", "Calories: 250, Carbs: 5g, Protein: 20g, Fat: 18g (per piece)" },
            { "samosa", "Calories: 140, Carbs: 15g, Protein: 3g, Fat: 8g (per piece)" },
            { "pakora", "Calories: 100, Carbs: 8g, Protein: 2g, Fat: 6g (per piece)" },
            { "naan", "Calories: 262, Carbs: 48g, Protein: 8g, Fat: 6g (per piece)" },
            { "karahi chicken", "Calories: 280, Carbs: 5g, Protein: 25g, Fat: 18g (per serving)" },
            { "lassi", "Calories: 150, Carbs: 12g, Protein: 6g, Fat: 8g (per glass)" },

            // International Dishes
            { "pizza", "Calories: 266, Carbs: 33g, Protein: 11g, Fat: 10g (per slice)" },
            { "burger", "Calories: 295, Carbs: 30g, Protein: 17g, Fat: 13g (per piece)" },
            { "pasta alfredo", "Calories: 310, Carbs: 40g, Protein: 10g, Fat: 12g (per serving)" },
            { "sushi", "Calories: 200, Carbs: 28g, Protein: 7g, Fat: 5g (per roll)" },
            { "tacos", "Calories: 170, Carbs: 13g, Protein: 8g, Fat: 10g (per piece)" },
            { "shawarma", "Calories: 300, Carbs: 25g, Protein: 20g, Fat: 15g (per roll)" },
            { "hummus", "Calories: 160, Carbs: 15g, Protein: 5g, Fat: 9g (per serving)" },
            { "lasagna", "Calories: 350, Carbs: 40g, Protein: 20g, Fat: 15g (per serving)" },

            // Street Foods
            { "golgappa", "Calories: 25, Carbs: 3g, Protein: 0.5g, Fat: 1g (per piece)" },
            { "chana chaat", "Calories: 150, Carbs: 22g, Protein: 7g, Fat: 3g (per serving)" },
            { "dahi puri", "Calories: 60, Carbs: 8g, Protein: 2g, Fat: 2g (per piece)" },
            { "roll paratha", "Calories: 400, Carbs: 35g, Protein: 15g, Fat: 20g (per roll)" },
            { "bun kebab", "Calories: 275, Carbs: 30g, Protein: 10g, Fat: 12g (per piece)" },

            // Cold Drinks
            { "cola", "Calories: 140, Carbs: 39g, Protein: 0g, Fat: 0g (per can)" },
            { "lemonade", "Calories: 120, Carbs: 30g, Protein: 0g, Fat: 0g (per glass)" },
            { "iced tea", "Calories: 90, Carbs: 22g, Protein: 0g, Fat: 0g (per glass)" },
            { "energy drink", "Calories: 110, Carbs: 28g, Protein: 1g, Fat: 0g (per can)" },

            // Dishes
            { "korma", "Calories: 350, Carbs: 10g, Protein: 20g, Fat: 25g (per serving)" },
            { "paya", "Calories: 300, Carbs: 5g, Protein: 15g, Fat: 20g (per serving)" },
            { "dal makhani", "Calories: 350, Carbs: 25g, Protein: 15g, Fat: 18g (per serving)" },

            // Seafood
            { "crab curry", "Calories: 180, Carbs: 5g, Protein: 20g, Fat: 8g (per serving)" },
            { "lobster", "Calories: 90, Carbs: 1g, Protein: 19g, Fat: 1g (per 100g)" },
            { "pomfret fry", "Calories: 220, Carbs: 2g, Protein: 25g, Fat: 12g (per piece)" },
            { "fish curry", "Calories: 200, Carbs: 4g, Protein: 25g, Fat: 10g (per serving)" },

            // Desserts
            { "gulab jamun", "Calories: 150, Carbs: 25g, Protein: 2g, Fat: 5g (per piece)" },
            { "jalebi", "Calories: 100, Carbs: 22g, Protein: 0.5g, Fat: 4g (per piece)" },
            { "kheer", "Calories: 200, Carbs: 30g, Protein: 5g, Fat: 6g (per serving)" },
            { "ice cream", "Calories: 207, Carbs: 24g, Protein: 3.5g, Fat: 11g (per scoop)" },
            { "brownie", "Calories: 290, Carbs: 36g, Protein: 4g, Fat: 14g (per piece)" },


        };




        // Search for FoodItem nutrition info
        private void txtIngredient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                e.SuppressKeyPress = true; // Prevent the default behavior (e.g., beep sound)
                btnSearchFoodItem.PerformClick(); // Trigger the button's click event
            }
        }




        //button search
        private async void btnSearchFoodItem_Click(object sender, EventArgs e)
        {
            string FoodItem = txtFoodItem.Text.ToLower().Trim();

            // Validation: Empty Input
            if (string.IsNullOrWhiteSpace(FoodItem))
            {
                MessageBox.Show("Food item field cannot be empty. Please enter a valid food item.", "Validation Error");
                txtFoodItem.Focus();
                return;
            }

            // Validation: Special Characters
            //if (!System.Text.RegularExpressions.Regex.IsMatch(FoodItem, @"^[a-zA-Z\s]+$"))
            //{
            //    MessageBox.Show("Food item name should only contain alphabets.", "Validation Error");
            //    txtFoodItem.Focus();
            //    return;
            //}

            // Validation: Length
            if (FoodItem.Length < 3)
            {
                MessageBox.Show("Food item name should be at least 3 characters long.", "Validation Error");
                txtFoodItem.Focus();
                return;
            }

            if (FoodItem.Length > 50)
            {
                MessageBox.Show("Food item name is too long. Please keep it under 50 characters.", "Validation Error");
                txtFoodItem.Focus();
                return;
            }

            // Check if any radio button is selected
            if (!IsAnyRadioButtonChecked())
            {
                error.SetError(groupBoxRadioButtons, "Please select a Search method.");
                return;
            }
            else
            {
                error.Clear();
            }


            if (string.IsNullOrEmpty(FoodItem))
            {
                MessageBox.Show("Please enter a valid food item.", "Input Error");
                return;
            }


            if (rbtnOffline.Checked)
            {
                // Offline search
                if (nutritionData.ContainsKey(FoodItem))
                {
                    lblNutritionInfo.Text = "Validating input... Please wait.";
                    await Task.Delay(800); // for better user feedback

                    lblNutritionInfo.Text = nutritionData[FoodItem];
                }
                else
                {
                    lblNutritionInfo.Text = "Ingredient not found in local database.";
                }
            }
            else if (rbtnOnline.Checked)
            {

                if (UserDataManager.CurrentUser != null)
                {
                    //disabling this for free members:
                    if (UserDataManager.CurrentUser.MembershipStatus == "Free" || UserDataManager.CurrentUser.MembershipStatus == null)
                    {
                        lblNutritionInfo.Text = "Upgrade to Premium to search online, for food items!";
                    }
                    else
                    {
                        // Online search
                        lblNutritionInfo.Text = "Searching online, please wait...";
                        string nutritionInfo = await GetNutritionInfo(FoodItem);

                        if (!string.IsNullOrEmpty(nutritionInfo) && !nutritionInfo.StartsWith("Error"))
                        {
                            lblNutritionInfo.Text = nutritionInfo;
                        }
                        else
                        {
                            MessageBox.Show("Food item not found online or invalid.", "Search Error");
                            lblNutritionInfo.Text = "Nutrition information not available.";
                        }
                    }
                }
                else
                {
                    lblNutritionInfo.Text = "You have to login to search online!";
                }
            }
        }


        //Nutritionix api for nutrition info
        private async Task<string> GetNutritionInfo(string foodItem)
        {
            string apiKey = "c71c93c9ef026c9c018df7285e7b660e";
            string appId = "f2cd5f94";
            string apiUrl = "https://trackapi.nutritionix.com/v2/natural/nutrients";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-app-id", appId);
                    client.DefaultRequestHeaders.Add("x-app-key", apiKey);

                    var requestBody = new { query = foodItem };

                    var jsonRequestBody = new StringContent(
                        Newtonsoft.Json.JsonConvert.SerializeObject(requestBody),
                        System.Text.Encoding.UTF8,
                        "application/json"
                    );

                    HttpResponseMessage response = await client.PostAsync(apiUrl, jsonRequestBody);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);

                        if (json["foods"] != null && json["foods"].HasValues)
                        {
                            JToken firstFood = json["foods"][0];

                            string foodName = firstFood["food_name"]?.ToString() ?? "Unknown";
                            string servingQty = firstFood["serving_qty"]?.ToString() ?? "1";
                            string servingUnit = firstFood["serving_unit"]?.ToString() ?? "unit";
                            string servingWeight = firstFood["serving_weight_grams"]?.ToString() ?? "N/A";

                            string calories = firstFood["nf_calories"]?.ToString() ?? "0";
                            string carbs = firstFood["nf_total_carbohydrate"]?.ToString() ?? "0";
                            string protein = firstFood["nf_protein"]?.ToString() ?? "0";
                            string fat = firstFood["nf_total_fat"]?.ToString() ?? "0";

                            return $"🍽 **{foodName.ToUpper()}**\n"
                                + $"📏 Quantity: {servingQty} {servingUnit} ({servingWeight}g)\n"
                                + $"🔥 Calories: {calories} kcal\n"
                                + $"🥖 Carbs: {carbs}g\n"
                                + $"💪 Protein: {protein}g\n"
                                + $"🧈 Fat: {fat}g";
                        }

                        return "⚠ No valid food item found.";
                    }
                    else
                    {
                        return $"❌ Error: {response.ReasonPhrase}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"⚠ An error occurred: {ex.Message}";
            }
        }







        //USDA api for nutrition info

        //private async Task<string> GetNutritionInfo(string foodItem)
        //{
        //    string apiKey = "83b4xpJNvvkEAjgrq7pxlLB2kvOPbaE1xF1qTRSY";
        //    string apiUrl = $"https://api.nal.usda.gov/fdc/v1/foods/search?query={foodItem}&api_key={apiKey}";

        //    try
        //    {
        //        using (HttpClient client = new HttpClient())
        //        {
        //            HttpResponseMessage response = await client.GetAsync(apiUrl);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string jsonResponse = await response.Content.ReadAsStringAsync();
        //                JObject json = JObject.Parse(jsonResponse);

        //                if (json["foods"] != null && json["foods"].HasValues)
        //                {
        //                    JToken firstFood = json["foods"][0];

        //                    // Check if it contains foodNutrients
        //                    if (firstFood["foodNutrients"] != null && firstFood["foodNutrients"].HasValues)
        //                    {
        //                        string description = firstFood["description"]?.ToString() ?? "Unknown";
        //                        string calories = firstFood["foodNutrients"]?.FirstOrDefault(n => n["nutrientName"]?.ToString() == "Energy")?["value"]?.ToString() ?? "0";

        //                        // Additional nutrient validation
        //                        if (calories != "0")
        //                        {
        //                            string carbs = firstFood["foodNutrients"]?.FirstOrDefault(n => n["nutrientName"]?.ToString() == "Carbohydrate, by difference")?["value"]?.ToString() ?? "0";
        //                            string protein = firstFood["foodNutrients"]?.FirstOrDefault(n => n["nutrientName"]?.ToString() == "Protein")?["value"]?.ToString() ?? "0";
        //                            string fat = firstFood["foodNutrients"]?.FirstOrDefault(n => n["nutrientName"]?.ToString() == "Total lipid (fat)")?["value"]?.ToString() ?? "0";

        //                            return $"Calories: {calories}, Carbs: {carbs}g, Protein: {protein}g, Fat: {fat}g";
        //                        }
        //                    }
        //                }

        //                return "No valid food item found.";
        //            }
        //            else
        //            {
        //                return $"Error: {response.ReasonPhrase}";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"An error occurred: {ex.Message}";
        //    }
        //}









        // Add item to custom plan

        // Breakfast
        private async void btnAddToBreakfast_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (txtFoodItem.Text.Contains("Type here") || string.IsNullOrEmpty(txtFoodItem.Text))
                {
                    MessageBox.Show("Please search any food item first!.");
                }
                else
                {
                    await AddFoodItemToList(txtFoodItem.Text, lstBreakfastInput);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }

        }

        // Lunch
        private async void btnAddToLunch_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (txtFoodItem.Text.Contains("Type here") || string.IsNullOrEmpty(txtFoodItem.Text))
                {
                    MessageBox.Show("Please search any food item first!.");
                }
                else
                {
                    await AddFoodItemToList(txtFoodItem.Text, lstLunchInput);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        // Snacks
        private async void btnAddToSnacks_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (txtFoodItem.Text.Contains("Type here") || string.IsNullOrEmpty(txtFoodItem.Text))
                {
                    MessageBox.Show("Please search any food item first!.");
                }
                else
                {
                    await AddFoodItemToList(txtFoodItem.Text, lstSnacksInput);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }

        // Dinner
        private async void btnAddToDinner_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                if (txtFoodItem.Text.Contains("Type here") || string.IsNullOrEmpty(txtFoodItem.Text))
                {
                    MessageBox.Show("Please search any food item first!.");
                }
                else
                {
                    await AddFoodItemToList(txtFoodItem.Text, lstDinnerInput);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }




        // Helper function to add food item to the specified list
        private async Task AddFoodItemToList(string foodItem, ListBox listBox)
        {
            foodItem = foodItem.ToLower().Trim(); // Ensure case-insensitivity and trim spaces

            if (!string.IsNullOrEmpty(foodItem))
            {
                // Check if the item already exists in the dictionary
                if (!nutritionData.ContainsKey(foodItem))
                {
                    // Fetch nutrition info from the Nutritionix API
                    string nutritionInfo = await GetNutritionInfo(foodItem);

                    if (!string.IsNullOrEmpty(nutritionInfo) && !nutritionInfo.StartsWith("Error") && !nutritionInfo.StartsWith("An error occurred") && nutritionInfo != "No results found for the FoodItem.")
                    {
                        // Add valid fetched data to the dictionary
                        nutritionData[foodItem] = nutritionInfo;
                    }
                    else
                    {
                        MessageBox.Show($"Could not fetch valid data for '{foodItem}'. Please check the spelling or try another item.", "Invalid Food Item");
                        return;
                    }
                }

                // Ensure the food item exists in the dictionary before adding to the diet plan
                if (nutritionData.ContainsKey(foodItem))
                {
                    listBox.Items.Add(foodItem); // Add item to the diet plan
                }
                else
                {
                    MessageBox.Show("Food item not found offline or online. Cannot add to the plan.", "Item Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid food item.", "Input Error");
            }
        }





        //remove from plan
        // Remove selected item from diet plan
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            // Check which ListBox has an item selected
            if (lstBreakfastInput.SelectedItem != null)
            {
                userDataManager.RemoveSelectedItem(lstBreakfastInput, "Breakfast");
            }
            else if (lstLunchInput.SelectedItem != null)
            {
                userDataManager.RemoveSelectedItem(lstLunchInput, "Lunch");
            }
            else if (lstSnacksInput.SelectedItem != null)
            {
                userDataManager.RemoveSelectedItem(lstSnacksInput, "Snacks");
            }
            else if (lstDinnerInput.SelectedItem != null)
            {
                userDataManager.RemoveSelectedItem(lstDinnerInput, "Dinner");
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }


        private async void btnCalculateTotalNutrition_Click(object sender, EventArgs e)
        {
            try
            {
                var breakfastNutrition = await CalculateMealNutritionAsync(lstBreakfastInput.Items);
                var lunchNutrition = await CalculateMealNutritionAsync(lstLunchInput.Items);
                var snacksNutrition = await CalculateMealNutritionAsync(lstSnacksInput.Items);
                var dinnerNutrition = await CalculateMealNutritionAsync(lstDinnerInput.Items);

                int totalCalories = breakfastNutrition.Calories + lunchNutrition.Calories + snacksNutrition.Calories + dinnerNutrition.Calories;
                double totalCarbs = breakfastNutrition.Carbs + lunchNutrition.Carbs + snacksNutrition.Carbs + dinnerNutrition.Carbs;
                double totalProtein = breakfastNutrition.Protein + lunchNutrition.Protein + snacksNutrition.Protein + dinnerNutrition.Protein;
                double totalFat = breakfastNutrition.Fat + lunchNutrition.Fat + snacksNutrition.Fat + dinnerNutrition.Fat;

                // Display formatted nutrition summary
                lblTotalNutrition.Text = $"📊 **Total Nutrition Values:**\n\n" +
                                         $"🔥 Calories: **{totalCalories} kcal**\n" +
                                         $"🥖 Carbs: **{totalCarbs}g**\n" +
                                         $"💪 Protein: **{totalProtein}g**\n" +
                                         $"🧈 Fat: **{totalFat}g**";
            }

            catch (Exception ex)
            {
                lblTotalNutrition.Text = $"⚠ An error occurred: {ex.Message}";
            }
        }




        private async Task<(int Calories, double Carbs, double Protein, double Fat)> CalculateMealNutritionAsync(ListBox.ObjectCollection items)
        {
            int mealCalories = 0;
            double totalCarbs = 0;
            double totalProtein = 0;
            double totalFat = 0;

            foreach (string item in items)
            {
                string foodItem = item.ToLower();
                string nutritionInfo;

                if (nutritionData.TryGetValue(foodItem, out nutritionInfo))
                {
                    int calories = ExtractCalories1(nutritionInfo);
                    double carbs = ExtractCarbs(nutritionInfo);
                    double protein = ExtractProtein(nutritionInfo);
                    double fat = ExtractFat(nutritionInfo);

                    mealCalories += calories;
                    totalCarbs += carbs;
                    totalProtein += protein;
                    totalFat += fat;
                }
                else
                {
                    nutritionInfo = await GetNutritionInfo(foodItem);

                    if (!nutritionInfo.StartsWith("Error") && !nutritionInfo.StartsWith("No results"))
                    {
                        int calories = ExtractCalories1(nutritionInfo);
                        double carbs = ExtractCarbs(nutritionInfo);
                        double protein = ExtractProtein(nutritionInfo);
                        double fat = ExtractFat(nutritionInfo);

                        mealCalories += calories;
                        totalCarbs += carbs;
                        totalProtein += protein;
                        totalFat += fat;

                        nutritionData[foodItem] = nutritionInfo;
                    }
                    else
                    {
                        MessageBox.Show($"Unable to fetch nutrition data for {foodItem}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            return (mealCalories, totalCarbs, totalProtein, totalFat);
        }



        private int ExtractCalories1(string nutritionInfo)
        {
            var match = Regex.Match(nutritionInfo, @"Calories:\s*(\d+)");
            return match.Success ? int.Parse(match.Groups[1].Value) : 0;
        }

        private double ExtractCarbs(string nutritionInfo)
        {
            var match = Regex.Match(nutritionInfo, @"Carbs:\s*(\d+(\.\d+)?)g");
            return match.Success ? double.Parse(match.Groups[1].Value) : 0.0;
        }

        private double ExtractProtein(string nutritionInfo)
        {
            var match = Regex.Match(nutritionInfo, @"Protein:\s*(\d+(\.\d+)?)g");
            return match.Success ? double.Parse(match.Groups[1].Value) : 0.0;
        }

        private double ExtractFat(string nutritionInfo)
        {
            var match = Regex.Match(nutritionInfo, @"Fat:\s*(\d+(\.\d+)?)g");
            return match.Success ? double.Parse(match.Groups[1].Value) : 0.0;
        }


        //database

        private void btnSaveDietPlan_Click(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                int userId = UserDataManager.CurrentUser.UserID; // Replace with actual logic to get the current user ID
                string notes = richTextBoxNotesInput.Text; // Get the notes from the RichTextBox

                userDataManager.SaveDietPlan(lstBreakfastInput, lstLunchInput, lstSnacksInput, lstDinnerInput, notes);
            }
            else
            {
                MessageBox.Show("No user is logged in.");
            }
        }



        private bool IsAnyRadioButtonChecked()
        {
            return rbtnOffline.Checked || rbtnOnline.Checked;
        }


        private void btnProfilePicture_MouseEnter_1(object sender, EventArgs e)
        {
            if (UserDataManager.CurrentUser != null)
            {
                toolTip1.SetToolTip(btnProfilePicture, $"{UserDataManager.CurrentUser.Username}'s Profile");
            }
            else
            {
                toolTip1.SetToolTip(btnProfilePicture, "Profile");
            }
        }


        //adding placeholder in txt box
        private void txtFoodItem_Enter(object sender, EventArgs e)
        {
            txtFoodItem.Text = "";
            txtFoodItem.ForeColor = Color.Black;
        }

        private void txtFoodItem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoodItem.Text))
            {
                txtFoodItem.Text = "Type here";
                txtFoodItem.ForeColor = Color.Gray;
            }
        }

        private void DietPlansForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Check if all forms are closed
            {
                Application.Exit(); // Exit the entire application
            }
        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            Features.OpenProfileForm();
            this.Hide();
        }
    }
}
