# 🧃 Wellness Witch

A simple full-stack .NET web app that lets users select and mix ingredients to create wellness shots. If the combination matches a known recipe, it's unlocked. If not, it's saved as a "Mystery Wellness."

Built using **ASP.NET Core (Razor Pages)** and **C#**, this app keeps front-end and back-end in one unified folder structure. It's perfect for learning and creative expression.

---

## ✨ Features (MoSCoW Prioritization)

### ✅ Must Have
- Users can select ingredients and their quantities
- Each recipe can have a specific quantity for each ingredient
- Mixes are checked against predefined recipes
- If a match is found: unlock and display the recipe
- If no match: show "Mystery Wellness" result
- Data is stored in memory or a simple `recipes.json` file
- Front-end and back-end exist together in a single Razor Pages project

### ✴️ Should Have
- Allow users to rate their wellness creations
- Let users name and save a mystery wellness shot
- Add custom mystery creations to the existing recipe list

### 🌸 Could Have
- Add images to each recipe or mystery shot
- Add animations for mixing and unlocking
- Play sound effects when mixing or unlocking
- Add ways to export (PDF, download, share link, etc.)
- Save a "Mystery Wellness" shot when no match is found
- Description of the wellness shot
- Description of the ingredients 

### 🚫 Won't Have (for now)
- Authentication (login/sign-up)
- Mobile app or Progressive Web App
- AI-based ingredient suggestions

---

## 🧪 Recipe Validation Rules

1. **Ingredient Count**
   - A valid recipe must have exactly **2 base ingredients** and exactly **2 topping ingredients**.

2. **Base Ingredients**
   - Must be selected from: `fruit`, `vegetable`, or `liquid`.
   - You cannot have 2 base ingredients of the same type (e.g., not 2 fruits).

3. **Topping Ingredients**
   - Must be selected from: `herb`, `powder`, `seed`, `spice`, or `flower`.
   - You cannot have 2 topping ingredients of the same type (e.g., not 2 herbs).

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- (Optional) [Visual Studio Code](https://code.visualstudio.com/) + C# extension

### Clone and Run the App

1. **Clone the repository:**
   ```bash
   git clone https://github.com/irmahs/WellnessWitch.git
   cd WellnessWitch
   ```
2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```
3. **Run the app with Hot Reload:**
   ```bash
   dotnet watch run
   ```
4. **Open your browser and go to:**
   - `https://localhost:5244/` (or the URL/port shown in your terminal)

You should see the Wellness Witch interface. Select your ingredients and brew your wellness shot!

```bash
dotnet new razor -n WellnessShotsApp
cd WellnessShotsApp
dotnet run
