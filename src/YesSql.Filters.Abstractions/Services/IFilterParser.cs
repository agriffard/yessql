namespace YesSql.Filters.Abstractions.Services
{
    public interface IFilterParser<TResult>
    {
        TResult Parse(string text);
    }
}
