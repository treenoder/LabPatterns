public class Main {
    public static void main(String[] args) {
        Party party = new Party();
        party.addCharacter(new Character("Alice", 100));
        party.addCharacter(new Character("Bob", 200));
        party.addCharacter(new Character("Charlie", 300));

        System.out.println("Party of characters:");
        while (party.hasNext()) {
            System.out.println(party.next());
        }
        party.reset();
        System.out.println();
        System.out.println("Party of characters after reset:");
        while (party.hasNext()) {
            System.out.println(party.next());
        }
    }
}