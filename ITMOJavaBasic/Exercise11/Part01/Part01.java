package ITMOJavaBasic.Exercise11.Part01;
import java.util.ArrayList;
import java.util.List;

public class Part01 {
    public static void main(String[] args) {
        runNumberPrinterThreads();
    }

    private static void runNumberPrinterThreads() {
        List<Thread> threads = new ArrayList<>();

        for (int i = 0; i < 10; i++) {
            Thread thread = new Thread(new NumberPrinter());
            System.out.println("Before starting thread " + i + ": " + thread.getState());
            threads.add(thread);
            thread.start();
            System.out.println("After starting thread " + i + ": " + thread.getState());
        }

        for (Thread thread : threads) {
            try {
                thread.join();
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}

class NumberPrinter implements Runnable {
    @Override
    public void run() {
        System.out.println("During execution of thread " + Thread.currentThread().getName() + ": " + Thread.currentThread().getState());
        for (int i = 0; i <= 100; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + i);
        }
    }
}
