from abc import ABC, abstractmethod


class Weapon(ABC):
    @abstractmethod
    def attack(self):
        pass


class Armor(ABC):
    @abstractmethod
    def defend(self):
        pass


class Sword(Weapon):
    def attack(self):
        return "Swinging sword"


class Bow(Weapon):
    def attack(self):
        return "Shooting arrow"


class Shield(Armor):
    def defend(self):
        return "Blocking with shield"


class LeatherArmor(Armor):
    def defend(self):
        return "Dodging with leather armor"
