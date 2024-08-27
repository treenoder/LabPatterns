package factory;

import items.Armor;
import items.Weapon;

public interface ItemFactory {
    Weapon createWeapon();

    Armor createArmor();
}
