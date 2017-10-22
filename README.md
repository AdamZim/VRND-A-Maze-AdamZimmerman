# A Maze Starter Project
By Adam Zimmerman

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.1.0p4
- GVR Unity SDK v1.70.0

## Credits
- coin/door code help but not at all copy and pasted: Erick Simoes https://github.com/ErickSimoes/maze_vr/
- nature sounds youtube to mp3: Only Nature: https://www.youtube.com/watch?v=qz54e2LWonM
- CoinPoof: instantiate a rotated object: Eric5h5: http://answers.unity3d.com/questions/123877/instantiate-a-rotated-object.html
- SignPost: borrowed 1 line from runeskape125: http://answers.unity3d.com/questions/1301342/restarting-the-scene-when-button-is-pressed.html

## Reflection - General
- I feel vastly underprepared. We'll see if I can garner the support I need in time!

## Reflection - 10/20/17
- Approximately 30 hours on this project so far
- No major problems doing the physical layout.
- Immediately running into problems setting up my scripts. So far I've done my best on both Coin.cs and Sign Post.cs. Please provide feedback.
- I found some source code for another student's project, but I don't want to plagarize it. I simply want to borrow a few lines in order to bootstrap myself - and always give credit here and within the script when doing so. Turns out, it's not been enough yet.
- I'm exhausted and demoralized for tonight, so I'm submitting what I have and hoping for constructive enough feedback to get me to help myself tomorrow in time for Tuesday's deadline. I expect to submit at least 3 times.
- Worst case scenario I miss the deadline and restart the whole course and do a better, faster, prettier job! I'm tired but optimistic.


## Reflection - 10/21/17
- 9am got coins completely working. I have a coin counter variable, but since it’s not in the rubric I’m not gonna add the count to the sign unless I finish everything else first. Interesting that for the rotation, I have to instantiate with a Euler angle, not just change the prefab's rotation within the inspector from the outset.
- 12:30pm got SignPost working.
- 1:30pm Key.cs works, or at least looks like it works. On to the door.
- 2pm updated CoinPoof.prefab to have a non-gravity rigid body instead of sphere collider, as per mentor's instructions.
- 4:25pm Imitated Erick Simoes' door.cs by calling public Door door instead of public GameObject Door. Adjusted door.Unlock() too which caused compiler errors to go away. Scene now runs but returns error: 	"Object reference not set to an instance of an object". Found Key had lost it's door component so readded it.

