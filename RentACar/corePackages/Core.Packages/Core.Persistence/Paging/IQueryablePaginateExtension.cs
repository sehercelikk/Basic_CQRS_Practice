using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Paging;

public static class IQueryablePaginateExtension
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(this IQueryable<T> query, int index, int size, CancellationToken cancellationToken = default)
    {
        int count= await query.CountAsync(cancellationToken).ConfigureAwait(false);

        List<T> items = await query.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

        Paginate<T> list = new()
        {
            Index = index,
            Count = count,
            Items = items,
            Size = size,
            Pages = (int)Math.Ceiling((double)count / size)
        };

        return list;
    }

    public static Paginate<T> ToPaginate<T>(this IQueryable<T> query, int index, int size)
    {
        int count = query.Count();

        List<T> items = query.Skip(index * size).Take(size).ToList();

        Paginate<T> list = new()
        {
            Index = index,
            Count = count,
            Items = items,
            Size = size,
            Pages = (int)Math.Ceiling((double)count / size)
        };

        return list;
    }
}
