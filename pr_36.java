// Inner class demonstration
public class pr_36 {
    // Outer class
    static class Outer {
        private String outerData = "Outer Class Data";
        
        // Inner class
        class Inner {
            private String innerData = "Inner Class Data";
            
            void displayInner() {
                System.out.println("Inner: " + innerData);
                System.out.println("Accessing Outer: " + outerData);
            }
        }
        
        void displayOuter() {
            System.out.println("Outer: " + outerData);
        }
    }
    
    public static void main(String[] args) {
        // Create Outer class instance
        Outer outer = new Outer();
        outer.displayOuter();
        
        // Create Inner class instance
        Outer.Inner inner = outer.new Inner();
        inner.displayInner();
    }
}
