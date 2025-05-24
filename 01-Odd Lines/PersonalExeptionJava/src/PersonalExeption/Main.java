package PersonalExeption;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true){
            int num = Integer.parseInt(scanner.nextLine());
            if (num < 0){
                try {
                    throw  new  PersonalExeption();
                } catch (PersonalExeption e) {
                    System.out.println(e.getMessage());
                    break;
                }
            }
        }
    }
}
