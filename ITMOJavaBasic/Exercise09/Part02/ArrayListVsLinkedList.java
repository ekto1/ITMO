package ITMOJavaBasic.Exercise09.Part02;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class ArrayListVsLinkedList {

    public static void arrayListVsLinkedList() {

        List<Double> arrayList = new ArrayList<>();
        List<Double> linkedList = new LinkedList<>();

        for (int i = 0; i <= 1000000; i++) {
            arrayList.add(Math.random());
            linkedList.add(Math.random());
        }
        long timeStart = System.currentTimeMillis();
        for (int i = 0; i < 1000000; i++) {
            arrayList.get((int) (Math.random() * (1000000 - 1)));
        }
        System.out.println("Время затраченное ArrayList: " + (System.currentTimeMillis() - timeStart));

        long timeStart2 = System.currentTimeMillis();
        for (int i = 0; i < 1000000; i++) {
            linkedList.get((int) (Math.random() * (1000000 - 1)));
        }
        System.out.println("Время затраченное linkedList: " + (System.currentTimeMillis() - timeStart2));
    }

    public static void main(String[] args) {
        arrayListVsLinkedList();
    }
}
