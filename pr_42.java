// StringBuffer demonstration
public class pr_42 {
    public static void main(String[] args) {
        System.out.println("=== StringBuffer append() ===");
        StringBuffer sb = new StringBuffer("Hello");
        sb.append(" World");
        System.out.println("After append: " + sb);
        sb.append(123);
        System.out.println("After append(123): " + sb);
        sb.append(true);
        System.out.println("After append(true): " + sb);
        
        System.out.println("\n=== StringBuffer insert() ===");
        StringBuffer sb2 = new StringBuffer("Hello World");
        System.out.println("Original: " + sb2);
        sb2.insert(6, "Beautiful ");
        System.out.println("After insert(6, \"Beautiful \"): " + sb2);
        
        System.out.println("\n=== StringBuffer reverse() ===");
        StringBuffer sb3 = new StringBuffer("Java");
        System.out.println("Original: " + sb3);
        sb3.reverse();
        System.out.println("After reverse(): " + sb3);
        
        System.out.println("\n=== StringBuffer delete() ===");
        StringBuffer sb4 = new StringBuffer("Hello World Java");
        System.out.println("Original: " + sb4);
        sb4.delete(6, 11);
        System.out.println("After delete(6, 11): " + sb4);
        
        System.out.println("\n=== StringBuffer deleteCharAt() ===");
        StringBuffer sb5 = new StringBuffer("Hello");
        System.out.println("Original: " + sb5);
        sb5.deleteCharAt(1);
        System.out.println("After deleteCharAt(1): " + sb5);
        
        System.out.println("\n=== StringBuffer length() and capacity() ===");
        StringBuffer sb6 = new StringBuffer("Test");
        System.out.println("String: \"" + sb6 + "\"");
        System.out.println("Length: " + sb6.length());
        System.out.println("Capacity: " + sb6.capacity());
        
        System.out.println("\n=== StringBuffer replace() ===");
        StringBuffer sb7 = new StringBuffer("Hello World");
        System.out.println("Original: " + sb7);
        sb7.replace(6, 11, "Java");
        System.out.println("After replace(6, 11, \"Java\"): " + sb7);
        
        System.out.println("\n=== StringBuffer toString() ===");
        StringBuffer sb8 = new StringBuffer("Convert to String");
        String str = sb8.toString();
        System.out.println("StringBuffer: " + sb8);
        System.out.println("Converted String: " + str);
        System.out.println("Type: " + str.getClass().getSimpleName());
    }
}
