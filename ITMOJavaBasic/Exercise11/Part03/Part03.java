package ITMOJavaBasic.Exercise11.Part03;

public class Part03 {

    public static void main(String[] args) {
        Object lock = new Object();
        Thread thread1 = new Thread(new CustomThread("Поток 1", lock));
        Thread thread2 = new Thread(new CustomThread("Поток 2", lock));
        thread1.start();
        thread2.start();
    }

    static class CustomThread implements Runnable {
        private String threadName;
        private Object lock;

        public CustomThread(String threadName, Object lock) {
            this.threadName = threadName;
            this.lock = lock;
        }

        @Override
        public void run() {
            while (true) {
                synchronized (lock) {
                    try {
                        System.out.println(threadName);
                        lock.notify();
                        lock.wait();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            }
        }
    }
}

