namespace Flyweight_Pattern
{
    public class CharacterFactory
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character GetCharacter(string name, string type, string image)
        {
            string key = $"{name}_{type}";
            if (_characters.ContainsKey(key)) return _characters[key];
            else
            {
                Character newCharacter = new Character(name, type, image);
                _characters[key] = newCharacter;
                return newCharacter;
            }
        }
    }
}
