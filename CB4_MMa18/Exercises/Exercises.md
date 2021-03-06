# Exercises

## Exercise *Tuition*
Create a simple class for students and give properties (Age, Name, Tuition Fee, Starting Date of studying, Phone Number). Create two constructors, the default one and one that takes as parameters all the properties. Create a method to raise students tuition based on a percentage. On runtime create three objects of this class and assign data to their properties through assignment, initialization and using the constructors.​

## Exercise *Circle*
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

## Exercise *Fraction*
1. Define a class Fraction, which contains information about the rational fraction (e.g. 1/4).  
2. Define the appropriate fields, properties and constructors.  
3. Override ToString() to print the Fraction (e.g. "1/4").  
4. Override operator * to multiply two Fractions.  
5. Define a static method Parse(string str) to create a Fraction from a string.
6. Define a property of type *decimal* to return the decimal value of the fraction (e.g. 0.25).  
7. Implement IComparable interface to enable sorting of Fractions.  
8. Write a function Cancel() to cancel the Fraction. (e.g. 10/15 is cancelled to 2/3).  
9. Test implemented functionality in Main().

## Exercise *CDPlayer*
Model the functionality of a CD player. The CD player reads a CD, which is comprised of tracks. Common functionality includes:
1. Showing the state of CD Player (loaded CD or not).  
2. Showing information of loaded CD.
3. Play from start.
4. Stop playing.
5. Play next/previous track.

Implement the necessary classes with appropriate properties and methods.
