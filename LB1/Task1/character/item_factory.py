from abc import ABC, abstractmethod

from LB1.Task1.character.item import Sword, Shield, Bow, LeatherArmor


class ItemFactory(ABC):
    @abstractmethod
    def create_weapon(self):
        pass

    @abstractmethod
    def create_armor(self):
        pass


class WarriorItemFactory(ItemFactory):
    def create_weapon(self):
        return Sword()

    def create_armor(self):
        return Shield()


class ArcherItemFactory(ItemFactory):
    def create_weapon(self):
        return Bow()

    def create_armor(self):
        return LeatherArmor()
