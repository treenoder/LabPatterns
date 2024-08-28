public abstract class Publisher {
    String host;
    int port;

    Publisher(String host, int port) {
        this.host = host;
        this.port = port;
    }

    public boolean publish(String topic, String message) {
        if (connect()) {
            boolean result = send(topic, message);
            disconnect();
            return result;
        }
        return false;
    }

    abstract boolean connect();

    abstract boolean send(String topic, String message);

    abstract void disconnect();
}
