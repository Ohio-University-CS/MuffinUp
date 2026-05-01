# MuffinUp!

A mod for the game **PlateUp!** that adds muffins and muffin variants as a fully playable meal option, complete with custom assets, ingredients, and cooking logic.

---

## Demo Video



---

## Features

- **Multiple Muffin Variants** — Play with a base muffin, Chocolate Chip Muffin, Blueberry Muffin, Lemon Muffin, and Cranberry Muffin.
- **Custom 3D Assets** — Unique Blender-created muffin models for each variant, including a Muffin Tin asset.
- **Full Recipe Integration** — Muffins use existing in-game ingredients (flour, sugar, eggs, milk, chocolate, cranberries, lemon) and appliances (oven, bowls, heated mixer, etc.).
- **Selectable Starting Meal** — The muffin dish can be selected as a starting meal at the beginning of a run.
- **Modular Codebase** — Built on top of KitchenLib and HarmonyX for clean mod integration with PlateUp!.

---

## Installation

This mod is deployed via GitHub Releases. Follow these steps to install the latest version of MuffinUp!:

1. **Download** — Go to the [Latest Release](https://github.com/Ohio-University-CS/MuffinUp/releases) page and download the `MuffinUp.zip` (or `.dll`) file.
2. **Locate Game Folder** — Open Steam, right-click *PlateUp!* → Manage → Browse local files.
3. **Install Required Mods** — MuffinUp! depends on two Steam Workshop mods. Subscribe to both before launching:
   - [KitchenLib](https://steamcommunity.com/sharedfiles/filedetails/?id=2898069883)
   - [HarmonyX](https://steamcommunity.com/sharedfiles/filedetails/?id=2898033283)
4. **Copy Files** — Navigate to the `Mods` folder inside the PlateUp! game directory. If it doesn't exist, create it. Drag and drop the downloaded `.dll` file into this folder.
5. **Launch** — Start the game. The new muffin variants will be available in the game menu.

> **Recommended:** Install the [Starting Meal Selector Mod](https://steamcommunity.com/sharedfiles/filedetails/?id=2898176672) so you can directly select the muffin dish without waiting for it to appear randomly.

---

## How to Run (For Developers)

### Environment Setup

1. **Locate your PlateUp! Mods folder:**
   - The default path is `C:\Program Files (x86)\Steam\steamapps\common\PlateUp\PlateUp\Mods`
   - To find it: right-click *PlateUp!* in Steam → Manage → Browse local files, then navigate to the `Mods` folder.

2. **Clone the repository** into your Mods folder:

    git clone https://github.com/Ohio-University-CS/MuffinUp
   
4. **Install VS Code Extensions** — Open the project in Visual Studio Code and install:
   - `.NET Install Tools` (Microsoft)
   - `.NET Extension Pack` (Microsoft)
   - C# extension

5. **Install .NET 10.0** — Download from the [official Microsoft website](https://dotnet.microsoft.com/en-us/download/dotnet/10.0). Once installed, the project should configure itself automatically via the `.csproj` file. If it doesn't, run:

                                                                                 ---

## Usage Examples

**Selecting the Muffin Dish:**
- At the start of a new run, open the meal selection menu (best with the Starting Meal Selector mod installed).
- Choose any muffin variant (e.g., Blueberry Muffin, Chocolate Chip Muffin) to begin your restaurant run.

**In-Game Preparation Flow (Example — Blueberry Muffin):**
1. Gather ingredients: flour, sugar, cracked egg, milk, blueberries.
2. Mix ingredients in a bowl using the Heated Mixer appliance.
3. Place the batter into the Muffin Tin.
4. Bake in the Oven.
5. Serve the finished muffin to customers.

> Screenshots and in-game footage are available in the Demo Video linked above.



## Known Issues

*

---

## Future Work

*

---

## Contributors
| Name | GitHub | Role |
|------|--------|------|
| Karli Nadsady | [@kn274621](https://github.com/kn274621) | Repository Management, Asset Integration, C# Coding |
| Blake Bysura | [@BBysura](https://github.com/BBysura) | Core Mod Development, Environment Setup, C# Coding |
| Ayesha Akbar | [@ayeshaakbr](https://github.com/ayeshaakbr) | C# Coding, Asset Uploads, Documentation |
