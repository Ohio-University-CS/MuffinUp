# Scope
The scope of this project is to create a mod for PlateUp! that adds muffins and their dependencies to the game.

## Game Objects to Create
These are game objects that will need to be created for our mod.

- Muffin
- Chocolate Chip Muffin
- Blueberry Muffin
- Lemon Muffin
- Cranberry Muffin
- Muffin Tin 
- (Optional) Muffin Cups

## Existing Game Objects
These are game objects that will be used in some form of preparation of the muffin. These objects do not need to be modified in any way.

### Ingredients
- Flour
- Sugar
- Cracked egg
- Milk
- Chocolate (chopped/cooked)
- Cranberries
- Lemon

### Appliances
- Bowls
- Cooking Appliances (Oven, Hob, Heated Mixer, etc.)



## Modifiable Game Objects
These are game objects that might not be used in their original form, but can be slightly modified for our use in the game.

- Cranberries -> Blueberries (both assets and code)
- Cookie Tray -> Muffin Tin (both assets and code)
- Cupcakes -> Muffins (code)


# Environment Setup
This is how to setup the coding environment and also compile the game to test.

## Folder Setup and Path

Make a folder inside the path to your PlateUp folder where the mods reside. The usual path is "C:\Program Files (x86)\Steam\steamapps\common\PlateUp\PlateUp\Mods", but can change based on system setup. To accurately find it, right click on the game in the Steam library and hover over over "Manage", then click on "Browse local files". You can then make the folder inside the Mods folder there.

## GitHub

Once the folder is ready, inside of the folder, clone the reprository of the main branch: `git clone https://github.com/Ohio-University-CS/MuffinUp`
Everything should be included to make the project work, so no more work is needed.

## Visual Studio Code

Before downloading .NET 10.0, you will need the accompanying extensions to go with .NET. There are only two needed for .NET in specific, but you will also need the C# extensions if not already added. The two you need are ".NET Install Tools" and ".NET Extension Pack", both published by Microsoft.

## .NET 10.0

In order to compile in the first place, you must download .NET 10.0 from the official Microsoft website (https://dotnet.microsoft.com/en-us/download/dotnet/10.0). Once downloaded, it should stop showing errors when opening the files for the MuffinUp modding folder as it should correctly read the .csproj file and set up the project to be compiled. If the project does not automatically setup, use `dotnet restore` and it will look for the .sln file to setup the project. When finished coding and wanting to test to work in-game, use `dotnet build` in the command line in order to compile. The game will automatically read the compiled .dll file and no more work is needed.

## 
