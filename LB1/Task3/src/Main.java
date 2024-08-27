import factory.ArcherItemFactory;
import factory.ItemFactory;
import factory.WarriorItemFactory;

public class Main {
    public static void main(String[] args) {
        Character warrior = createCharacter(new WarriorItemFactory());
        warrior.attack();
        warrior.defend();
        Character archer = createCharacter(new ArcherItemFactory());
        archer.attack();
        archer.defend();
    }

    public static Character createCharacter(ItemFactory factory) {
        return new Character(factory.createWeapon(), factory.createArmor());
    }
}