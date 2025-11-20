namespace Core.Persistence.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }
    public int Size { get; set; } // Sayfada kaç data var
    public int Index { get; set; } // Hangi sayfada olduğumuz
    public int Count { get; set; } // Toplam kayıt sayısı
    public int Pages { get; set; } // Toplam kaç sayfa var
    public IList<T> Items { get; set; } // Datalar ne
    public bool HasPrevious => Index > 0; // Önceki sayfa var mı
    public bool HasNext => Index+1 < Pages; // Sonraki sayfa var mı
}
