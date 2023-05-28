package ITMOJavaBasic.Exercise11.Part02;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.CountDownLatch;

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
        int numThreads = 100;
        CountDownLatch latch = new CountDownLatch(numThreads);
        Thread[] threads = new Thread[numThreads];

        for (int i = 0; i < numThreads; i++) {
            threads[i] = new Thread(() -> {
                for (int j = 0; j < 1000; j++) {
                    counter.increment();
                }
                latch.countDown();
            });
            threads[i].start();
        }
        latch.await();
        }
    }


