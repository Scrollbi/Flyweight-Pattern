using Flyweight_Pattern;

public class Program
{
    public static void Main()
    {
        CharacterFactory characterFactory = new CharacterFactory();

        Character character1 = characterFactory.GetCharacter("Hero", "Character1", "Character1.png");
        Character character2 = characterFactory.GetCharacter("Hero", "Character2", "Character2.png");
        Character character3 = characterFactory.GetCharacter("Hero", "Character1", "Character1.png"); // Этот персонаж будет возвращен

        // Изменение нелегковесных атрибутов
        character1.Level = 100;
        character1.Experience = 100;

        character2.Level = 0;
        character2.Experience = 50;

        Console.WriteLine($"Name - {character1.Name} ({character1.Type}) - LVL: {character1.Level}, EXP: {character1.Experience}" +
            $"\nName - {character2.Name} ({character2.Type}) - LVL: {character2.Level}, EXP: {character2.Experience}" +
            $"\nName -  {character3.Name} ({character3.Type}) - LVL: {character3.Level}, EXP: {character3.Experience}");
    }
}