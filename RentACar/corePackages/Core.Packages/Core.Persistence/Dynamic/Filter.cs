namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; } //Filtre hangi alan üzerinde( örneğin yakıt tipi)
    public string? Value { get; set; } // Field ın değeri ne
    public string Operator { get; set; } // Eşitlik, büyüktür, küçüktür gibi operatörler
    public string? Logic  { get; set; } // and or sorguları için
    public IEnumerable<Filter> Filters { get; set; } // Birden fazla filtre uygulayabilmek için

    public Filter()
    {
        Field=string.Empty;
        Operator = string.Empty;
    }
    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}

