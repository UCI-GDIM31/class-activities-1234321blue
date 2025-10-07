# in-class-activities
## Devlogs
### W1
When we move the camera object off the cat object, the camera doesn't move. This happens as our ability to move is in the player component attatched to the cat. The camera itself doesn't have any moving capabilities, so it can only move when attatched to the cat, who can move.

### W2
1. The r, g, and b variables are trying to hold numerical values with decimals. This means they are definitely not strings, as they aren't storing words, or bools, as they aren't holding true of false values. In addition to this, the numbers they are storing are not whole numbers, meaning they can't be an int variable. Floats, on the other hand, can hold numerical values with decimals, meaning they are probably the best variable type for our r, g, and b variables.
2. The _bounce variable is best suited as an int type variable as it is just trying to store the value of whole numbers.
3. The error we had to fix in step 4 was adding the semi-colon to the end of the line of code, which was indicated in the console by the error message "; expected".

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 