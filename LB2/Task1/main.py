from collections.abc import Iterator


class Items(Iterator):
    def __init__(self, items: list):
        self.items = items

    def __next__(self):
        if not self.items:
            raise StopIteration
        return self.items.pop(0)


class LoggedItems(Iterator):
    def __init__(self, iterator):
        self.iterator = iterator

    def __next__(self):
        item = next(self.iterator)
        print(f"Log of item: {item}")
        return item


def main():
    items = Items(list(range(3)))
    for i in items:
        print("Printing item:", i)
    print("-" * 10)
    logged_items = LoggedItems(Items(list(range(3))))
    for i in logged_items:
        print("Printing item:", i)


if __name__ == '__main__':
    main()
