// Wrapper classes demonstration
public class pr_40 {
    public static void main(String[] args) {
        System.out.println("=== Autoboxing ===");
        // Autoboxing: Converting primitive to wrapper
        int intValue = 10;
        Integer intWrapper = intValue;  // Autoboxing
        System.out.println("int to Integer: " + intWrapper);
        
        double doubleValue = 3.14;
        Double doubleWrapper = doubleValue;  // Autoboxing
        System.out.println("double to Double: " + doubleWrapper);
        
        char charValue = 'A';
        Character charWrapper = charValue;  // Autoboxing
        System.out.println("char to Character: " + charWrapper);
        
        System.out.println("\n=== Unboxing ===");
        // Unboxing: Converting wrapper to primitive
        Integer num = 25;
        int unboxedInt = num;  // Unboxing
        System.out.println("Integer to int: " + unboxedInt);
        
        Double decimal = 5.99;
        double unboxedDouble = decimal;  // Unboxing
        System.out.println("Double to double: " + unboxedDouble);
        
        System.out.println("\n=== Parsing from Strings ===");
        // Parse integer from string
        String strInt = "100";
        int parsedInt = Integer.parseInt(strInt);
        System.out.println("Parse \"100\" to int: " + parsedInt);
        
        // Parse double from string
        String strDouble = "3.14159";
        double parsedDouble = Double.parseDouble(strDouble);
        System.out.println("Parse \"3.14159\" to double: " + parsedDouble);
        
        // Parse character from string
        String strChar = "X";
        char parsedChar = strChar.charAt(0);
        System.out.println("Parse \"X\" to char: " + parsedChar);
        
        // Parse boolean from string
        String strBoolean = "true";
        boolean parsedBoolean = Boolean.parseBoolean(strBoolean);
        System.out.println("Parse \"true\" to boolean: " + parsedBoolean);
        
        System.out.println("\n=== Wrapper Methods ===");
        System.out.println("Integer.MAX_VALUE: " + Integer.MAX_VALUE);
        System.out.println("Integer.MIN_VALUE: " + Integer.MIN_VALUE);
        System.out.println("Double.MAX_VALUE: " + Double.MAX_VALUE);
        System.out.println("Character.isDigit('5'): " + Character.isDigit('5'));
        System.out.println("Character.isLetter('A'): " + Character.isLetter('A'));
    }
}
