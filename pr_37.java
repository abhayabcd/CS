// Abstract class and method implementation
public class pr_37 {
    // Abstract class
    static abstract class Shape {
        private String color;
        
        Shape(String color) {
            this.color = color;
        }
        
        // Abstract method
        abstract double area();
        
        void displayColor() {
            System.out.println("Color: " + color);
        }
    }
    
    // Concrete implementation: Circle
    static class Circle extends Shape {
        private double radius;
        
        Circle(String color, double radius) {
            super(color);
            this.radius = radius;
        }
        
        @Override
        double area() {
            return Math.PI * radius * radius;
        }
        
        @Override
        void displayColor() {
            super.displayColor();
            System.out.println("Radius: " + radius);
        }
    }
    
    public static void main(String[] args) {
        Circle circle = new Circle("Red", 5.0);
        circle.displayColor();
        System.out.println("Area of Circle: " + circle.area());
    }
}
