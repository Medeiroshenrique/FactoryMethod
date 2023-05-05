namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter ChooseCharacter(string character)
        {
            switch (character)
            {
                case "1": return new LiuKang();
                case "2": return new Raiden();
                case "3": return new JonnyCage();
                default: return null;
            }
        }
    }
}
