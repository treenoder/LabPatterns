import items.Armor;
import items.Weapon;

public class Character {
    private final Weapon weapon;
    private final Armor armor;

    public Character(Weapon weapon, Armor armor) {
        this.weapon = weapon;
        this.armor = armor;
    }

    public void attack() {
        this.weapon.attack();
    }

    public void defend() {
        this.armor.defend();
    }
}
