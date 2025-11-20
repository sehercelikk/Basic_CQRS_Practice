namespace Core.Persistence.Dynamic;
// Verileri sıralamak için(a dan z ye gibi)
public class Sort
{
    public string Field { get; set; } // Hangi alana göre sıralama yapılacağı
    public string Dir { get; set; } // Sıralamanın hangi yönde olacağı

    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }
    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }

}
