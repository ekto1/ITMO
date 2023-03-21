package ITMOJavaBasic.Exercise09.Part01;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Collection{

    public static void main(String[] args) {

        List<Integer> collection = new ArrayList<>();

        collection.add(23);
        collection.add(23);
        collection.add(23);
        collection.add(23);
        collection.add(23);
        collection.add(23);

        Set<Integer> uniqueCollection = new HashSet<>(collection);
        System.out.println(uniqueCollection);
    }




}
