# Yuxi-2D-Unity-DoodleJump

A 2D Unity-based platformer game inspired by the classic Doodle Jump. Players control a character that jumps between platforms while avoiding obstacles and reaching higher scores.

## Features
- **Dynamic Camera System**: Smooth camera following the player.
- **Procedural Level Generation**: Endless platform generation for continuous gameplay.
- **Player Movement**: Intuitive and responsive controls to move the character.
- **Animated Effects**: Includes animations for idle and breaking platforms.

## Repository Contents
- `Camera_follow.cs`: Handles the camera movement to follow the player.
- `ChangeSide.cs`: Implements character side-switching mechanics.
- `Doodler.cs`: Core script for controlling the player's character.
- `LevelGenerator.cs`: Procedural generation for platforms and obstacles.
- `Platform.cs`: Script for platform behavior (e.g., breakable platforms).
- `Platform (2).controller`: Controls animations and properties of platforms.
- `Weak_Idle.anim` and `Weak_break.anim`: Animations for weak platforms.
- `Doodle-Jump.exe`: Executable file to play the game.
- `README.md`: Documentation for the repository.

## Getting Started

### Prerequisites
- Unity 2D Engine (Version 2020.3 or newer recommended)
- A Windows system for running the provided executable file.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/Yuxi-2D-Unity-DoodleJump.git
2. Open the project in Unity:
- Launch Unity Hub.
- Select Add project and navigate to the cloned repository.
3. Run the game:
- Open `Doodle-Jump.exe` to play the game.

### Usage
- **Play the Game:** Launch the `.exe` file to experience the fun of platform jumping.
- **Customize Levels:** Modify the `LevelGenerator.cs` script to change platform spawning logic.
- **Enhance Player Controls:** Update the `Doodler.cs` script to tweak jump physics or add new abilities.

## Future Improvements
- Add collectible items and power-ups.
- Introduce enemies or hazards to avoid.
- Implement a scoring and leaderboard system.
- Add new themes or environments.

## Contributing
Contributions are welcome! If you'd like to contribute:
1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Submit a pull request with a detailed explanation of your changes.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.
