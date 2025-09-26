# 🗺️ Text-Based RPG / Adventure Map

A simple **C# console-based RPG** where the player explores a map, picks up items, fights enemies, and completes objectives. This project is designed to teach you **object-oriented programming**, **game loops**, and **JSON data handling**.

---

## 🎯 Goal

Build a text-based adventure game that:

- Lets the player move between rooms
- Allows picking up and using items  
- Includes combat with enemies  
- Uses data-driven maps, items, and enemies from JSON files  

---

## 📚 Features

- World map defined in JSON  
- Player inventory and stats  
- Turn-based combat system  
- Command-driven input (move, look, pick up, attack)  
- Save and load game data (optional)  

---

## 🗂️ Project Structure

```c#
AdventureGame/
├─ Program.cs // Entry point and main game loop
├─ Game.cs // Controls overall game state and loop
├─ Player.cs // Player model (name, health, inventory)
├─ Enemy.cs // Enemy model (type, health, attack)
├─ Item.cs // Item model (name, type, effect)
├─ World.cs // Map and room data
├─ Room.cs // Single room (description, exits, items, enemies)
├─ Commands.cs // Command parser/handler (move, look, pick up, attack)
├─ data/
│ ├─ map.json // Map layout and room descriptions
│ ├─ enemies.json // Enemy definitions
│ ├─ items.json // Item definitions
└─ README.md
```

---

## ⚙️ How It Works

1. Load the map, items, and enemies from JSON files at startup.  
2. Create the player object and place them in a starting room.  
3. Enter a game loop:  
   - Show current room description and available actions  
   - Accept and parse player commands  
   - Update the game state based on actions (move, pick up item, attack enemy)  
4. Track player health, inventory, and progress.  
5. End the game when the player reaches a win condition or dies.  

---

## 📝 Data Files Example Structure

### map.json

```json
[
  {
    "Id": "start",
    "Description": "You are in a small hut with a door to the north.",
    "Exits": {"north": "forest"},
    "Items": ["key"],
    "Enemies": []
  },
  {
    "Id": "forest",
    "Description": "A dark forest surrounds you. Paths lead east and south.",
    "Exits": {"south": "start", "east": "cave"},
    "Items": ["potion"],
    "Enemies": ["goblin"]
  }
]
```

### enemies.json

```json
[
  {"Name": "Goblin", "Health": 20, "Attack": 5},
  {"Name": "Orc", "Health": 40, "Attack": 10}
]
```

### items.json

```json
[
  {"Name": "Key", "Type": "Key", "Effect": null},
  {"Name": "Potion", "Type": "Consumable", "Effect": {"Health": +10}}
]
```

## 🎯 Learning Goals

- Use C# classes, inheritance, and interfaces

- Implement a game loop with state management

- Work with collections and object relationships

- Load and manage external data via JSON

- Structure a medium-size console project

## 🛠️ Possible Improvements

- Leveling up and experience points

- NPCs with dialogue or quests

- Save/load feature for player progress

- Procedurally generated maps

- Timed events or random encounters

## 🚀 Getting Started

1. Create the file structure above.

2. Define your map, items, and enemies in JSON.

3. Implement the classes to load data and run the game loop.

4. Explore, fight, and collect items!

5. Run with:

```bash
dotnet run
```
# Text-Based_Adventure
