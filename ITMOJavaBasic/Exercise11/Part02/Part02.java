package ITMOJavaBasic.Exercise11.Part02;
import java.util.concurrent.atomic.AtomicInteger;

class Counter {
    private AtomicInteger count = new AtomicInteger(0);

    public void increment() {
        count.incrementAndGet();
    }

    public int getCount() {
        return count.get();
    }
}

public class Part02 {
    public static void main(String[] args) throws InterruptedException {
        Counter counter = new Counter();
        startThreads(counter);
        System.out.println("Final count value: " + counter.getCount());
    }

    public static void startThreads(Counter counter) throws InterruptedException {
        Thread[] threads = new Thread[100];

        for (int i = 0; i < 100; i++) {
            threads[i] = new Thread(() -> {
                for (int j = 0; j < 1000; j++) {
                    counter.increment();
                }
            });
            threads[i].start();
        }

        for (Thread thread : threads) {
            thread.join();
        }
    }
}

