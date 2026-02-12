// String class operations
public class pr_41 {
    public static void main(String[] args) {
        System.out.println("=== String Concatenation ===");
        String str1 = "Hello";
        String str2 = "World";
        String concatenated = str1 + " " + str2;
        System.out.println("Concatenation: " + concatenated);
        
        String result = str1.concat(" ").concat(str2);
        System.out.println("Using concat(): " + result);
        
        System.out.println("\n=== String Length ===");
        String text = "Java Programming";
        System.out.println("String: \"" + text + "\"");
        System.out.println("Length: " + text.length());
        
        System.out.println("\n=== String Comparison ===");
        String str3 = "Java";
        String str4 = "Java";
        String str5 = "JAVA";
        
        System.out.println("\"Java\".equals(\"Java\"): " + str3.equals(str4));
        System.out.println("\"Java\".equals(\"JAVA\"): " + str3.equals(str5));
        System.out.println("\"Java\".equalsIgnoreCase(\"JAVA\"): " + str3.equalsIgnoreCase(str5));
        System.out.println("\"Java\".compareTo(\"Java\"): " + str3.compareTo(str4));
        System.out.println("\"Java\".compareTo(\"Kotlin\"): " + str3.compareTo("Kotlin"));
        
        System.out.println("\n=== Substring Check ===");
        String sentence = "Java is a powerful language";
        System.out.println("String: \"" + sentence + "\"");
        System.out.println("Contains \"powerful\": " + sentence.contains("powerful"));
        System.out.println("Contains \"Python\": " + sentence.contains("Python"));
        System.out.println("startsWith(\"Java\"): " + sentence.startsWith("Java"));
        System.out.println("endsWith(\"language\"): " + sentence.endsWith("language"));
        System.out.println("indexOf(\"is\"): " + sentence.indexOf("is"));
        
        System.out.println("\n=== Substring ===");
        System.out.println("substring(0, 4): " + sentence.substring(0, 4));
        System.out.println("substring(5): " + sentence.substring(5));
        
        System.out.println("\n=== Case Conversion ===");
        String original = "Java Programming";
        System.out.println("Original: " + original);
        System.out.println("toUpperCase(): " + original.toUpperCase());
        System.out.println("toLowerCase(): " + original.toLowerCase());
        
        System.out.println("\n=== Other Operations ===");
        String spaces = "  Hello World  ";
        System.out.println("Original: \"" + spaces + "\"");
        System.out.println("trim(): \"" + spaces.trim() + "\"");
        
        String replaced = "Hello World World";
        System.out.println("Original: \"" + replaced + "\"");
        System.out.println("replace(\"World\", \"Java\"): \"" + replaced.replace("World", "Java") + "\"");
        
        String split = "Java,Python,C++,JavaScript";
        String[] parts = split.split(",");
        System.out.println("Split \"Java,Python,C++,JavaScript\" by comma:");
        for (String part : parts) {
            System.out.println("  - " + part);
        }
    }
}
