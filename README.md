# ComputerTechnologyCourseFG21 SpaceShooter
Space Shooter using DOTS 0.51
Windows Build in Builds > Windows

Includes - 
- Simple Movements (Enemies, Asteroids, & Player) 
- Shooting 
- Waves of Enemies & Obstacles 


## Components 
- Tags (Asteroid, Player, Projectile)
- General Transform Component (See Below) 
- Game Settings Component + Game Settings Authoring Script 
- Prefabs Collection Component


## How to play: 
- Press space to spawn
- Press space after spawning to shoot
- WASD for movement 


## General Transform Component 
Since all entities spawning in the game will require a similar set of information for movements, the following properties where included in a General Transform Component (TransformComponent) : 
- Speed
- Rotation Speed 
- Direction 
- Switch DirectionX & Switch DirectionY (Bools) 
- Health
Health and Swithc direction is not in use

## Systems
A number of systems were created, each handling only 1 aspect of the behaviour of an entity type(besides the spawning the player and movement of the player)


## Game Settings Component & Prefabs Collection Component
Both the Game Settings Component (with seperate authoring script) and the Prefabs Collection Component were created to allow fast editing and reference storage of required values and components. 

