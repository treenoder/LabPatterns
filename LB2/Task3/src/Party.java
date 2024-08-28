import java.util.ArrayList;

public class Party implements CharacterIterator {
    private final ArrayList<Character> characters = new ArrayList<>();
    private int currentPosition = 0;

    public void addCharacter(Character character) {
        characters.add(character);
    }

    @Override
    public boolean hasNext() {
        return currentPosition < characters.size();
    }

    @Override
    public Character next() {
        if (!hasNext()) {
            return null;
        }
        return characters.get(currentPosition++);
    }

    @Override
    public void reset() {
        currentPosition = 0;
    }
}
