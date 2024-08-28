public class Main {
    public static void main(String[] args) {
        Publisher redisPublisher = new RedisPublisher("localhost", 6379);
        if (!redisPublisher.publish("topic", "message")) {
            System.out.println("Failed to publish message to Redis");
        }

        System.out.println();

        Publisher rabbitMqPublisher = new RabbitMqPublisher("localhost", 5672);
        if (!rabbitMqPublisher.publish("topic", "message")) {
            System.out.println("Failed to publish message to RabbitMQ");
        }
    }
}