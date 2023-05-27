using Shared.Model;

namespace Shared.Service;

public class BookmarkService
{
    public async Task<List<Bookmark>> GetBookmarks()
    {
        await Task.CompletedTask;
        return new List<Bookmark>()
        {
            new Bookmark { Guid="4581ef7e-c70e-441f-9d6a-a8432e1256dd", Title="Google", Url="https://google.com", Description="The Mighty Göøgle"},
            new Bookmark { Guid="698a6201-3c9c-4367-a65b-ca3a6ea6b416", Title="Microsoft", Url="https://microsoft.com", Description="The Good Ol´ M$"},
            new Bookmark { Guid="a7f169e5-5f97-41c5-8461-cf0a9621151b", Title="ANUG", Url="https://anug.dk", Description="Aarhus .Net User Group"},
        };
    } 
}
