// Math class demonstration
public class pr_39 {
    public static void main(String[] args) {
        // max() - returns maximum of two numbers
        System.out.println("=== Math.max() ===");
        System.out.println("max(10, 20) = " + Math.max(10, 20));
        System.out.println("max(100.5, 50.3) = " + Math.max(100.5, 50.3));
        
        // min() - returns minimum of two numbers
        System.out.println("\n=== Math.min() ===");
        System.out.println("min(10, 20) = " + Math.min(10, 20));
        System.out.println("min(100.5, 50.3) = " + Math.min(100.5, 50.3));
        
        // sqrt() - returns square root
        System.out.println("\n=== Math.sqrt() ===");
        System.out.println("sqrt(16) = " + Math.sqrt(16));
        System.out.println("sqrt(25) = " + Math.sqrt(25));
        System.out.println("sqrt(2) = " + Math.sqrt(2));
        
        // abs() - returns absolute value
        System.out.println("\n=== Math.abs() ===");
        System.out.println("abs(-10) = " + Math.abs(-10));
        System.out.println("abs(-5.5) = " + Math.abs(-5.5));
        System.out.println("abs(10) = " + Math.abs(10));
        
        // pow() - returns power
        System.out.println("\n=== Math.pow() ===");
        System.out.println("pow(2, 3) = " + Math.pow(2, 3));
        System.out.println("pow(5, 2) = " + Math.pow(5, 2));
        System.out.println("pow(10, 0) = " + Math.pow(10, 0));
        
        // Rounding methods
        System.out.println("\n=== Rounding ===");
        double num = 3.7;
        System.out.println("ceil(3.7) = " + Math.ceil(num));
        System.out.println("floor(3.7) = " + Math.floor(num));
        System.out.println("round(3.7) = " + Math.round(num));
        System.out.println("round(3.2) = " + Math.round(3.2));
    }
}
