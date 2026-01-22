# Data-Persistance-Project-Unity
+ It is a classic arcade-style game, built in **Unity** using **C#**.  
+ This project was developed by following the Junior Programmer Pathway Course from Unity Learn.

### 🚀 **Features**

- 👨🍳 **Single-player Arcade Action gameplay** – Experience classic, fast-paced gameplay where the objective is to destroy bricks and maximize your score.
- 🛒  **Data Persistence Between Scenes** – Built with seamless data management that saves the High Scorer’s Name and Best Score across different scenes and sessions.
- 🖥️ **Personalized Start** - Features a Player Input Field ✍️ at the beginning, ensuring every record set is tied to a specific player's identity.
- 🎨 **Clean UI/UX design** – A minimalist and intuitive interface featuring:
     - Score Counter 🔢 to track your current run.
     - Hall of Fame Display 🏆 showing the all-time best score.
- 🎮 **Keyboard controls** for easy gameplay.

### 🛠️ **Tech Stack**

- **Engine:** Unity (Recommended version: **Unity 6.0.62f1 LTS**)  
- **Language:** C#  
- **Assets:** Junior Programmer Pathway free assets and prefabs  
- **IDE:** Visual Studio Code / Rider / Visual Studio

### 📂 **Project Structure**

```plaintext
Assets/
├── Materials/        # Textures and surface shaders for game objects
├── Prefabs/          # Reusable game objects (Ball, Bricks, Paddle)
├── Scenes/           # Main game levels and UI menus
├── Scripts/          # C# Logic and Game Mechanics
│   ├── DataSaver/    # Persistence logic (JSON/Binary saving)
│   ├── Managers/     # Singletons and Game State Controllers
│   ├── UI/           # Menu navigation and HUD logic
│   ├── Ball.cs       # Physics and bounce behavior
│   ├── Brick.cs      # Health and destruction logic
│   ├── DeathZone.cs  # Game over trigger handling
│   └── Paddle.cs     # Input and movement handling
├── Settings/         # URP and Project configuration files
└── TextMesh Pro/     # UI styling and font assets
```

### 🕹️ **Controls**
+  Move Player : Left and Right Arrow Keys
+  Shoot / Launch Ball : SpaceBar

### 📥 **Installation & Setup**
+ 1. **Clone or Download this repository:**
   ```bash
     https://github.com/faizankhan19504/Junior-Unity-Project.git
     
2. **Open the project in Unity Hub (Recommended: Unity 6.0.62f1 LTS).**

3. **Open the StartMenu:**
   
      +    Assets/Scenes/StartMenu

4. **Press Play to start the game.**

### 🧠 **Learning Objectives**
+ This project covers:
    + Unity basics (GameObjects, Components, Prefabs)
    + C# scripting in Unity
    + Player input handling
    + UI management
    + Physics and collision detection
    + Scene management
    + Data Persistence
 
### 🙌 **Acknowledgements**
+ Developed by following Junior Programmer Pathway Course.
+ Free assets provided by Unity Learn.

