public class RabbitMqPublisher extends Publisher {
    RabbitMqPublisher(String host, int port) {
        super(host, port);
    }

    @Override
    boolean connect() {
        System.out.println("Unable to connect to RabbitMQ");
        return false;
    }

    @Override
    boolean send(String topic, String message) {
        System.out.println("Sent message to RabbitMQ");
        System.out.println("Topic: " + topic);
        System.out.println("Message: " + message);
        return true;
    }

    @Override
    void disconnect() {
        System.out.println("Disconnected from RabbitMQ");
    }
}
