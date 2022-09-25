# UnityScripts
Scripts to control some game objects

HoldBall.cs
      -> When this script is attached to a GameObject, the Collider object that it hits will have its position transformed as the same as the GameObjects Position
         *Note that the collided object can be hidden since it is transformed as same coordinates.
      -> Commented out portion transforms position to directly above GameObject rather than it's own coordinates.

MoveTransformPositionWithInput.cs
      -> Move GameObject with arrow keys.
      -> Movement is choppy

MoveTransformPositionWithInputSmoothly.cs
      -> Move GameObejct with arrow keys.
      -> Movement includes adjustable speed variable - movement is smoother than above file.
      
RegisterGoal.cs
      -> When a GameObect with tag "Ball" hits Object that this script is attached to - Debug indicates a goal and increments each OnTrigger Enter Event.

      

