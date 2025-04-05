🎮 PixelSnowboarder
Built in Unity (C#) — designed, coded, and animated solo as part of my game dev learning path.

✅ Project Overview
PixelSnowboarder is a chill yet engaging 2D snowboarding game focused on player flow, flipping tricks, and not crashing before reaching the finish line. It combines fun physics, satisfying controls, smooth visuals, and meaningful particle + sound feedback for immersive moment-to-moment gameplay.

🧩 Key Gameplay Mechanics
Player smoothly rides along a snowy terrain using Sprite Shape + Surface Effector 2D
![image](https://github.com/user-attachments/assets/a44d8194-b59a-4ed4-ab5d-fbf3484f8c96)

Can rotate forward/backward mid-air and boost speed with Arrow keys

Crashing (head hits) and reaching the finish line trigger particles + sound, then restart level with delay

Dust Trail particle system activates only when board is grounded, and scales dynamically based on boost

Cinemachine virtual camera follows player with smooth damping and smart framing

🧠 Code & System Design Highlights
 Modular scripting: PlayerController, CrashDetector, FinishLine, DustTrail all separated by concern

💡 Neat use of:

FindAnyObjectByType<> for inter-script communication

Tag-based collision detection for clean logic

ParticleSystem MainModule access for dynamic sizing

🎮 Player controls feel tight and responsive with physics-based torque & force

 Technical Components
System                    Implementation
Physics                   Rigidbody2D, CapsuleCollider2D, CircleColliders
Camera	                  Cinemachine with Framing Transposer & Damping
Terrain	                  Sprite Shape Controller for organic slope design
Movement	                SurfaceEffector2D for player movement based on slope angle
Particles	                Triggered effects for crashing, movement, and win state
Sound	                    AudioSource plays crash SFX and finish SFX
Restart                   Logic	SceneManager reloads level with delay using Invoke()

🔧 Main Scripts Used
PlayerController.cs – Controls movement, boosting, torque

CrashDetector.cs – Triggers crash effects & restarts level

FinishLine.cs – Detects finish, plays win effects & reloads

DustTrail.cs – Starts/stops ground trail + dynamic particle size control

                                                                                                    💬 Developer's Note:
One of the funnies challenges was implementing dynamic particle trails that only activate when touching the ground, and increase in size when boosting. It helped me deeply understand Unity’s physics, collision detection, and real-time particle control.


🖼️ Gameplay Preview
🔥 Boost & spin in motion
![Unity_sxwhdaaj7v](https://github.com/user-attachments/assets/115816e1-a78c-4708-8bc3-1486141d52c8)
![Unity_scj8deB7Fn](https://github.com/user-attachments/assets/09a0136f-f0b8-477f-a17e-fe6beb86798e)

💥 Crash effect & restart logic
![Unity_4O1qvMnWcx](https://github.com/user-attachments/assets/d7c767d1-ea75-4b15-82f8-a5b4c708a9ae)
