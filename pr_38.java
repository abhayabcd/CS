// Final class demonstration
import java.util.Random;
import java.util.Scanner;
import java.util.ArrayList;
import java.util.HashMap;
import java.lang.*;
class pr_38 {
    public static void main(String[] args) {
        System.out.println("MathConstants is a final class and cannot be extended.");
        MathConstants.displayConstants();
        System.out.println("\nAccessing constants directly:");
        System.out.println("PI = " + MathConstants.PI);
        System.out.println("E = " + MathConstants.E);
        System.out.println("Golden Ratio = " + MathConstants.GOLDEN_RATIO);
    }
    // Final class - cannot be extended
    static final class MathConstants {
        // Constants
        static final double PI = 3.14159265359;
        static final double E = 2.71828182846;
        static final double GOLDEN_RATIO = 1.61803398875;
        
        // Private constructor to prevent instantiation
        private MathConstants() {
        }
        
        static void displayConstants() {
            System.out.println("Pi: " + PI);
            System.out.println("Euler's Number: " + E);
            System.out.println("Golden Ratio: " + GOLDEN_RATIO);
        }
    }
    
    // This would cause a compilation error if uncommented
    // static class ExtendedMath extends MathConstants { }
    
    
}
