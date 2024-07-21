from LB1.Task1.character.character import Character
from LB1.Task1.character.item_factory import WarriorItemFactory, ArcherItemFactory


def create_character(factory) -> Character:
    weapon = factory.create_weapon()
    armor = factory.create_armor()
    return Character(weapon, armor)


def main():
    warrior = create_character(WarriorItemFactory())
    print(warrior.attack())
    print(warrior.defend())
    archer = create_character(ArcherItemFactory())
    print(archer.attack())
    print(archer.defend())


if __name__ == '__main__':
    main()
