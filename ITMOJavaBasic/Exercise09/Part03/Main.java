package ITMOJavaBasic.Exercise09.Part03;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Map<User, Integer> gameScore = new HashMap<>();

        User user1 = new User("Lily");
        User user2 = new User("Bob");
        User user3 = new User("Scott");
        User user4 = new User("Carl");

        gameScore.put(user1, 5);
        gameScore.put(user2, 10);
        gameScore.put(user3, 4);
        gameScore.put(user4, 12);

        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите имя игрока: ");
        String gamer = scanner.nextLine();

        // System.out.println("Количество очков игрока " + gamer + " : " + gameScore.get());

        boolean playerIsExist = false;

        for(Map.Entry<User, Integer> entry : gameScore.entrySet()) {
            if(entry.getKey().getName().equals(gamer)) {
                System.out.println("Количество очков игрока " + gamer + " : " + entry.getValue());
                playerIsExist = true;
            }
        }

        if (!playerIsExist) {
            System.out.println("Такого игрока не существует.");
        }
    }
}
