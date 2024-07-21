from LB1.Task1.character.item import Weapon, Armor


class Character:
    def __init__(self, weapon: Weapon, armor: Armor):
        self.weapon = weapon
        self.armor = armor

    def attack(self) -> str:
        return self.weapon.attack()

    def defend(self) -> str:
        return self.armor.defend()
