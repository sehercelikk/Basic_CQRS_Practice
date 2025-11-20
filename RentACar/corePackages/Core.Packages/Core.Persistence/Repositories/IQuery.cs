//Proje içerisinden sql sorgusu çalıştırabilmek için bu interface tanımlandı
namespace Core.Persistence.Repositories;

public interface IQuery<T>
{
    IQueryable<T> Query();  // Bu hareketle Query.Where(x=>x.Id==2) gibi sorgular yazılabilir
}
