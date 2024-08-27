package factory;

import items.Armor;
import items.Bow;
import items.LeatherArmor;
import items.Weapon;

public class ArcherItemFactory implements ItemFactory {
    @Override
    public Weapon createWeapon() {
        return new Bow();
    }

    @Override
    public Armor createArmor() {
        return new LeatherArmor();
    }

}
