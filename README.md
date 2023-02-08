# Unity 2D game made as an assessment.

Premise: Cut your potatoes to make your french fries.

Reel: https://youtu.be/xuYYlmCMD4k

# Stages:

## 1. Main Menu:
   Main menu starts your game with 2 options, Play Game and Quit Game. Play game will take you the gameplay. Quit game will quit your game.
![Alt text](https://github.com/SauravP10/French-Fries/blob/main/Documentation/1%20(5).png "Main Menu")

## 2. Gameplay
   In play game window, you'll see potatoes flying around on screen. Use your left mouse button to cut them in half. With each potato cut, you'll get 10 points, which can be seen on top right corner of the screen.
![Alt text](https://github.com/SauravP10/French-Fries/blob/main/Documentation/1%20(1).png "Gameplay 1")
![Alt text](https://github.com/SauravP10/French-Fries/blob/main/Documentation/1%20(4).png "Gameplay 2")

## 3 Pause Menu
  On pressing 'Escape' key you will able to pause your game. From there you can go back to Main Menu or you can Quit the game or you can start where you left off.
![Alt text](https://github.com/SauravP10/French-Fries/blob/main/Documentation/1%20(8).png "Pause Menu")

## 4.End Screen
  Once you score 100 points your game will be over and it'll take you to the End screen.
![Alt text](https://github.com/SauravP10/French-Fries/blob/main/Documentation/1%20(7).png "End Screen")

# Scripts:

## 1. Main Menu Script
   Main menu script uses UI elements such as Canvas, Panel, Buttons, and TextMeshPro. Each button has been coded to its fuctionality. Play Game uses Scene Manager to load the next stage. Quit game quits your application.
   
## 2. Pause Menu Script
   Pause script has 3 buttons added using UI elements. The pause menu is binded to the 'Escape' key. In the Update method, the pause menu becomes active and freezes the game functions. It contains Pause(), Resume(), MainMenu(), and QuitGame() methods.
   
## 3. Slicer Script
   The slicer is the main feature of this game. It is navigated using mouse in world place. On pressing the left mouse button the the slicer is activated and letting go of left mouse button stops the slicer. The slicer has Rigidbody2D,  CircleCollider2D, and Trail Renderer attached to it. The SlicerPos calculates the position from where it touches the potato and from there it slices the potato in half.
   
## 4. Veg Script
   The veg script is for the potato. It also contains RigidBody2D and CircleCollider2D. RigidBody2D gives the object its gravity and an additional force is added to throw the object upwards. CircleCollider2D recognizes the CircleCollider2D in the Slicer and when it does it slices the object into 2 pieces. The slicing is done using 2 spheres which has collider on them and once they are instantiated the pushes each other apart. As you slice the potatoes, your score gets added to the score text on the top righ corner.
   
## 5. Veggie Spawner Script
   This script is used to spawn the potatoes on the screen. There are 7 positions where the potatoes can be spawned. These 7 transforms has been rotated in certain angles to randomize its upwards movement.
   
## 7. Score Script
   This script keeps a track of the score board. In the Awake() method an instance of this script has been created which is used in Veg script. With each potato cut it adds 10 points to the score. Once you hit 100 points the game is over and it takes you to the end screen.
   
   
