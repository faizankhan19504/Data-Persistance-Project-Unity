# Data-Persistance-Project-Unity
+ It is a classic arcade-style game, built in **Unity** using **C#**.  
+ This project was developed by following the Junior Programmer Pathway Course from Unity Learn.

<img width="1004" height="564" alt="Snap1 0" src="https://github.com/user-attachments/assets/1ac9ca39-fd3e-4d95-b11e-95c8f5cc54cf" />

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

<img width="999" height="562" alt="Snap2 0" src="https://github.com/user-attachments/assets/f5503a06-a279-4fcb-8bc2-737446b466f9" />

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
     https://github.com/faizankhan19504/Data-Persistance-Project-Unity.git
     
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

### 📜 **License**
+ This project is for educational purposes only. Assets and code are credited to UnityLearn.
+ Do not redistribute commercially without proper permission.


