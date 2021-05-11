# Car Race Game
## Description
For the race track, I used a terrain and filled it with some hills and trees and created a racetrack surrounded by them. I used trees that I found from a Unity Asset because I felt it looked realistic and it had colliders and it moved, which gave it a good look. I used the Unity Standard Assets Vehicle for the car implementation; it comes with the car controls which I think is a better implementation than what I was planning to do. It has good car animation and sounds and it helps me with a problem I was having with other cars; where they would fall once I run the project.  I used a unity asset for the player’s car because it looked cooler, and the standard assets car for the AI’s car model. I added the Need for Speed music as a background music for the race to make it sound more fun. I implemented a timer that counts the recent lap and the last lap. I did so by having two triggers; one for the finish line and one in the middle of the track. The triggers track the player’s position to differentiate between laps. Once the player reaches the half-point trigger; it activates the finish line trigger, so once the player reaches the finish line; a lap will be counted and their time will be saved. Those triggers also help in counting the laps, along with one more trigger that determines if the player finished both of their laps, and stops the game to show the result. For the AI, I used waypoint tracking system where the car has an array of points to go to, and once it reaches the finish line, the index of the array becomes 0, and the AI uses the same points to reach the finish line. For the camera angle, I attached the main camera to the back of the car, and I moved the main camera to be the child of the car so it will follow the car. Also, I added a script that better conveys the camera angle in case the car flips. There are colliders for all of the items on my map, and the tricks also use Trigger colliders to determine if the player passed through them. My program also determines who is first or second in the race according to the position of the player to the AI Car. I have two objects on the AI car; one on the front and one on the back. The front one detects if the player is in front of it, and the back one detects if the player is behind the AI. I had a hard time figuring out how to implement the triggers and just detecting the player, not the AI, but I was finally able to implement it. The game ends when the player finishes their second lap.

## Controls To Access The Project
You just need to download the project to unity and open “MainScene” and run the program and start racing. 

## Controls
W/Up Arrow: Drive forward

A/left arrow: Move left

S/back arrow: Brake; keep holding to go back

D/right arrow: Move right

## Assets
Player Car: https://assetstore.unity.com/packages/3d/vehicles/land/hq-racing-car-model-no-1202-128064

Unity Standard Assets: https://unity3d.com/get-unity/download/archive
I used version Unity 2017 4.40, and imported the cars assets from there.

Trees: https://assetstore.unity.com/packages/3d/vegetation/trees/conifers-botd-142076

Music: https://www.youtube.com/watch?v=kG5LF_QS1JU&t=30s

## Images 
![image](https://user-images.githubusercontent.com/55646048/117859888-96677f80-b25d-11eb-9435-3ed62d9a7208.png)

![image](https://user-images.githubusercontent.com/55646048/117859908-9f585100-b25d-11eb-9621-084400b7c78e.png)

![image](https://user-images.githubusercontent.com/55646048/117859915-a3846e80-b25d-11eb-9cc5-5255089e610e.png)

![image](https://user-images.githubusercontent.com/55646048/117859922-a7b08c00-b25d-11eb-9f2c-558a5462fac4.png)

![image](https://user-images.githubusercontent.com/55646048/117859933-abdca980-b25d-11eb-9e64-60351b0980f9.png)

![image](https://user-images.githubusercontent.com/55646048/117859915-a3846e80-b25d-11eb-9cc5-5255089e610e.png)

![image](https://user-images.githubusercontent.com/55646048/117859954-b26b2100-b25d-11eb-9405-0851554e350f.png)
