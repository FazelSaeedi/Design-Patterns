namespace Design_Patterns.Behavioral.Strategy
{
    public interface IHashStrategy
    {
        byte[] hash(string raw);

        delegate void Print(string message);

    }
}
