using CQRSProject.CQRS.Results;
using CQRSProject.DAL;
using System.Reflection.Metadata;

namespace CQRSProject.CQRS.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler
{
    private readonly Context _context;

    public GetCategoryQueryHandler(Context context)
    {
        _context = context;
    }
    public List<GetCategoryQueryResult> Handle()
    {
        var values = _context.Categories.Select(x => new GetCategoryQueryResult
        {
            CategoryID = x.CategoryID,
            CategoryName = x.CategoryName,
        }).ToList();
        return values;
    }
}
