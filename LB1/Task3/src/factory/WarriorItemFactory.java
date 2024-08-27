package factory;

import items.Armor;
import items.Shield;
import items.Sword;
import items.Weapon;

public class WarriorItemFactory implements ItemFactory {
    @Override
    public Weapon createWeapon() {
        return new Sword();
    }

    @Override
    public Armor createArmor() {
        return new Shield();
    }
}
