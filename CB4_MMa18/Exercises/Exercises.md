# Exercises

## Exercise_Tuition
Create a simple class for students and give properties (Age, Name, Tuition Fee, Starting Date of studying, Phone Number). Create two constructors, the default one and one that takes as parameters all the properties. Create a method to raise students tuition based on a percentage. On runtime create three objects of this class and assign data to their properties through assignment, initialization and using the constructors.​

## Exercise_Circle
1. Create a class called Circle that contains:
   * Two properties: Radius (of the type double) and Color (of the type String), with default value of 1.0 and "red", respectively. 
   * Two overloaded constructors - a default constructor with no argument, and a constructor which takes a double argument for radius. 
   * Two public methods: SetRadius() and SetColor() that sets the radius and color, respectively. 
   * One public method: GetArea(), which return the area of this instance.
2. Create a class called Color that contains three properties, R, G, B that represent the values of red, green, blue channels.
3. Update class Circle, so it has two properties for fill color and border color that are representated by Color. (delete previous Property Color and update constructors and methods)
4. Create a class Point, that representes a point in 2d space (x,y).
5. Update class Circle, so it has a center point.
6. Create a method in class Circle, IsPointInCircle(Point p), that checks if a Point p is inside the circle.
7. Test the above in Main(). Ask user to create a circle, and then enter a point. Print if point is inside the circle.