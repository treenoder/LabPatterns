public class RedisPublisher extends Publisher {
    RedisPublisher(String host, int port) {
        super(host, port);
    }

    @Override
    boolean connect() {
        System.out.println("Connected to Redis");
        return true;
    }

    @Override
    boolean send(String topic, String message) {
        System.out.println("Sent message to Redis");
        System.out.println("Topic: " + topic);
        System.out.println("Message: " + message);
        return true;
    }

    @Override
    void disconnect() {
        System.out.println("Disconnected from Redis");
    }
}
