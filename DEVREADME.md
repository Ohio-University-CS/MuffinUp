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

## .NET 10.0

In order to compile in the first place, you must download .NET 10.0 from the official Microsoft website (https://dotnet.microsoft.com/en-us/download/dotnet/10.0). Once downloaded, it should stop showing errors when opening the files for the MuffinUp modding folder as it should correctly read the .csproj file and set up the project to be compiled. When finished coding and wanting to test to work in-game, use `dotnet build` in the command line in order to compile. The game will automatically read the compiled .dll file and no more work is needed.

## 
