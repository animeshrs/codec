# codec
Mars question
The code is implemented in the file Program.cs of **MarsQuestion** project.
Program class contains GetMarsHoverCoordinatesAndDirection method which is responsible for taking maximum x an y values to draw the grid and then command to get the final coordinate and direction.
Sample run of input is showed below:

**Enter x value:**
5
**Enter y value:**
5
**Enter command:**
FFRFLFLF

**Services** project contains MarsServices.cs file which has methods to get the direction and get the updated coordinate.
**For getting updated direction**- UpdatedDirection method is used which takes 2 parameters - command (e.g. F, L, R) and direction (North, West, East etc) 
**For getting updated coordinates**- GetUpdatedCoodinates method is used which takes 4 parameters - command (e.g. F, L, R), direction (North, West, East etc), 
    current X Coordinate, current Y Coordinate, maximum X Coordinate and maximum Y Coordinate

**MarsQuestion.Tests** project contains test cases for above mentioned methods.





