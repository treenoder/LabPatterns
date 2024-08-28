public class Character {
    private final String name;
    private final int health;

    public Character(String name, int health) {
        this.name = name;
        this.health = health;
    }

    public String toString() {
        return "Character: " + name + ", Health: " + health;
    }
}
