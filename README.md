<br/>
<div align="center">
  <a href="https://github.com/ArcticKangaroo/50-Shooter/"><img src="icon.png" alt="Logo" width="80" height="80"></a>
  <h3 align="center">50 Shooter</h3>
  <p align="center"><i>A top-down arcade shooter made using Unity and C#</i></p>
</div>

![Screenshot](https://user-images.githubusercontent.com/62847649/204500989-8ba21d1e-62ed-4c28-9e76-d2ccf5e89add.png)

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about">About</a></li>
    <li><a href="#how-to-run">How To Run</a></li>
    <li><a href="#gameplay">Gameplay</a></li>
    <li><a href="#post-mortem">Post Mortem</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>

## About
An endless top down shooter game where you have to defend yourself by attacking enemies to rack up points, until they finally overpower you. 

##### Some quick details:

- Made in: Unity 2021.3
- Language: C#
- 3D engine: Blender
- Time to make: ~6 days
- Platform: Windows (can be compiled for Linux & Mac too)

## How To Run
Download `50 Shooter.zip` from the [Releases](https://github.com/ArcticKangaroo/50-Shooter/releases/) page. Uncompress and run `50 Shooter.exe`.

## Gameplay
![Gameplay](https://user-images.githubusercontent.com/62847649/204509513-8f4db52b-6e0e-4209-9390-3d5c49bd1f20.gif)

## Post Mortem
- I designed a game map and provided a set of enemy spawn points to an Enemy Spawner script, which instantiates an enemy at intervals of time getting shorter as the game progresses, to add more difficulty. Each enemy also spawns with a random speed to shake things up a bit and add some variety.

- For input, I used the new Unity Input System and set up an Input Actions asset. I also set up Player Input component and paired it with a Player Controller script to get my character movement up and running.

- I programmed a script for instantiating projectiles, and created a bullet projectile which gets destroyed on hitting walls or enemies using colliders. I added a small blue trail to each bullet, so they're always distinguishable.

- I created a screen space UI using a Canvas along with Text to display basic information such as the score and the player health bar. For the enemy health bars, I used a world space canvas to make the health bars follow the enemy characters.

- Lastly, I used the Unity particle system to add some visual effects when the player or an enemy dies. This was probably my favourite part of this project, because the result ends up looking really cool.

## License
Distributed under the MIT License. See `LICENSE` for more information.
