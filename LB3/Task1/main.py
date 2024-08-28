from abc import ABC, abstractmethod


class Subject(ABC):
    @abstractmethod
    def attach(self, observer: 'Observer'):
        pass

    @abstractmethod
    def detach(self, observer: 'Observer'):
        pass

    @abstractmethod
    def notify(self):
        pass


class Observer(ABC):
    def update(self, subject: Subject):
        pass


class Character(Subject):
    def __init__(self):
        self._observers = []
        self.points = 0

    def attach(self, observer: Observer):
        self._observers.append(observer)

    def detach(self, observer: Observer):
        self._observers.remove(observer)

    def notify(self):
        for observer in self._observers:
            observer.update(self)

    def collect_points(self, points: int):
        self.points += points
        self.notify()


class CharacterObserver(Observer):
    def update(self, subject: Character):
        print(f"Character points: {subject.points}")


def main():
    character = Character()
    observer = CharacterObserver()

    character.attach(observer)
    character.collect_points(10)
    character.collect_points(10)

    character.detach(observer)
    character.collect_points(10)


if __name__ == '__main__':
    main()
