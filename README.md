# in-class-activities
## Devlogs
### W1
When we move the camera object off the cat object, the camera doesn't move. This happens as our ability to move is in the player component attatched to the cat. The camera itself doesn't have any moving capabilities, so it can only move when attatched to the cat, who can move.

### W2
1. The r, g, and b variables are trying to hold numerical values with decimals. This means they are definitely not strings, as they aren't storing words, or bools, as they aren't holding true of false values. In addition to this, the numbers they are storing are not whole numbers, meaning they can't be an int variable. Floats, on the other hand, can hold numerical values with decimals, meaning they are probably the best variable type for our r, g, and b variables.
2. The _bounce variable is best suited as an int type variable as it is just trying to store the value of whole numbers.
3. The error we had to fix in step 4 was adding the semi-colon to the end of the line of code, which was indicated in the console by the error message "; expected".

### W3
Table 3
1. We would make the return type a boolean as we want to know whether or not the player hit the key on time, so it is a yes or no question, aka a true or false output. For the input, we thought the method should hold that the method is false, as if the player isn't hitting the key on time, we want to make sure that the method stay false. Otherwise, it'll be changed somehow in the method if the player hit the key on time.
2. A metaphor to compare components, classes, methods, and member variables is a concert. The concert as a whole is the component while the class is the performance on that stage. Within the performance, the people performing and doing work to keep the technology running are the member variables as they are the ones actually performing. The instruments and tools they use are the methods as they are what allow the people, or member variables to actually do something on stage.
3. I think the balls get extremely bright when they bounce too many times because there isn't a method that decrease their brightness over time, so they will just continue to bounce and only increase their brightness to infinity or until they bounce off the screen.

### W4
Table 3
1. Line 5 declares the member variable of _moveSpeed, which is of type float, and sets it value to 1.0f. The private before it keeps it contained to this class, and [SerializeField] makes it so we can see and change the variable within the Inspector tab in Unity. Line 22 declares a variable within the Update method, which is variable translation of type float. The value is set to whatever the player's vertical axis is times the value their current movement speed, times the value of the member variable deltaTime of class Time. In line 25, we are calling the method Translate from variable transform with the arguments that the value of x is 0, y is 0, and z is the value of variable translation, which was defined in line 22.
2. We added Rigidbodies to the Cat and the SoccerBall objects as they both needed to be able to collide with each other. We added a trigger to the goal to detect when the ball entered or hit the goal.
3. We got an error where we forgot to make the method return void, so the method was still expecting some variable to be returned. We just had to change the method's return type to void.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 