🏂 PixelSnowboarder
Built in Unity (C#) — designed, coded, and animated solo as part of my game dev learning journey.

🧊 Project Overview
PixelSnowboarder is a chill but engaging 2D snowboarding game focused on smooth motion, mid-air flips, and avoiding crashes before reaching the finish line.
Built to explore Unity’s physics, particle systems, and clean modular scripting, it offers satisfying player control and smart gameplay feedback using visual, audio, and camera tools.

🕹️ Gameplay Features
❄️ Smooth downhill movement using Sprite Shape + Surface Effector 2D

🔄 Mid-air flips and torque-based rotation (Left/Right Arrow keys)

🚀 Boost system (Up Arrow) increases speed dynamically

💥 Crash detection using colliders triggers particles + sound, then restarts the level

🎉 Finish line triggers win effects (particles, SFX, level reload)

🌬️ Dust trail system only activates on ground contact, dynamically resizes while boosting

🎥 Cinemachine camera for smooth-follow and screen composition

🧠 Code & System Design Highlights
🧩 Modular scripts: PlayerController, CrashDetector, FinishLine, DustTrail

🧠 Inter-script communication via FindAnyObjectByType<>()

🏷️ Tag-based collision logic

🌟 Particle sizing via MainModule.startSize control

🌀 Smooth physics behavior using Rigidbody2D, Torque, and SurfaceEffector2D

⏱️ Delayed restart logic using SceneManager.LoadScene() with Invoke()

🔊 Audio feedback for crash/win events using AudioSource.PlayOneShot()
🔧 Main Scripts Overview
Script	                              Role
PlayerController.cs	                 Movement, torque rotation, boost control
CrashDetector.cs	                    Detects collisions, triggers crash FX, restarts level
FinishLine.cs	                       Detects win state, plays finish FX, reloads level
DustTrail.cs	                        Activates/deactivates trail, controls size on boost
                                                                                                  
✨ Developer Insight
One of the most satisfying challenges for me was setting up dynamic particle trails that only activate when grounded and increase in size while boosting. It deepened my understanding of Unity physics, particle systems, and real-time interaction between scripts. But surely there is many more things I'm proud of! :D


🖼️ Gameplay Preview
🔥 Boost & spin in motion
![Unity_sxwhdaaj7v](https://github.com/user-attachments/assets/115816e1-a78c-4708-8bc3-1486141d52c8)
![Unity_scj8deB7Fn](https://github.com/user-attachments/assets/09a0136f-f0b8-477f-a17e-fe6beb86798e)

💥 Crash effect & restart logic
![Unity_4O1qvMnWcx](https://github.com/user-attachments/assets/d7c767d1-ea75-4b15-82f8-a5b4c708a9ae)
