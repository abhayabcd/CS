// Random class demonstration
public class pr_43 {
    public static void main(String[] args) {
        java.util.Random random = new java.util.Random();
        
        System.out.println("=== Random Integers ===");
        System.out.println("Generate 5 random integers:");
        for (int i = 0; i < 5; i++) {
            System.out.println("  " + (i + 1) + ". " + random.nextInt());
        }
        
        System.out.println("\n=== Random Integers in Range ===");
        System.out.println("Generate 5 random integers between 1 and 100:");
        for (int i = 0; i < 5; i++) {
            int randomInt = random.nextInt(100) + 1;
            System.out.println("  " + (i + 1) + ". " + randomInt);
        }
        
        System.out.println("\n=== Random Floats ===");
        System.out.println("Generate 5 random floats (0.0 to 1.0):");
        for (int i = 0; i < 5; i++) {
            System.out.println("  " + (i + 1) + ". " + random.nextFloat());
        }
        
        System.out.println("\n=== Random Doubles ===");
        System.out.println("Generate 5 random doubles (0.0 to 1.0):");
        for (int i = 0; i < 5; i++) {
            System.out.println("  " + (i + 1) + ". " + random.nextDouble());
        }
        
        System.out.println("\n=== Random Booleans ===");
        System.out.println("Generate 10 random booleans:");
        for (int i = 0; i < 10; i++) {
            System.out.print(random.nextBoolean() + " ");
        }
        System.out.println();
        
        System.out.println("\n=== Use in Calculations ===");
        System.out.println("Coin Flip Simulation (10 flips):");
        int heads = 0, tails = 0;
        for (int i = 0; i < 10; i++) {
            if (random.nextBoolean()) {
                heads++;
                System.out.print("H ");
            } else {
                tails++;
                System.out.print("T ");
            }
        }
        System.out.println("\nHeads: " + heads + ", Tails: " + tails);
        
        System.out.println("\n=== Dice Roll Simulation ===");
        System.out.println("Roll a dice 6 times:");
        int sum = 0;
        for (int i = 0; i < 6; i++) {
            int dice = random.nextInt(6) + 1;
            sum += dice;
            System.out.println("  Roll " + (i + 1) + ": " + dice);
        }
        System.out.println("Sum of all rolls: " + sum);
        
        System.out.println("\n=== Random Event Simulation ===");
        System.out.println("Simulate 5 events with 30% success rate:");
        for (int i = 0; i < 5; i++) {
            double probability = random.nextDouble();
            boolean success = probability < 0.3;
            System.out.println("  Event " + (i + 1) + ": " + (success ? "SUCCESS" : "FAILED") + 
                             " (probability: " + String.format("%.2f", probability) + ")");
        }
    }
}
