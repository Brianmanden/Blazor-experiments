using SharedModels.Model;

namespace SharedModels.Service;

public interface IBookmarkService { 
    public Task<List<Bookmark>> GetBookmarks();
    Task AddBookmark(Bookmark bookmark);
    Task<Bookmark> GetBookmark(string bookmarkGuid);
    Task UpdateBookmark(Bookmark bookmark);
    //Task DeleteBookmark(string bookmarkGuid);
}

public class BookmarkService : IBookmarkService
{
    private List<Bookmark> _dummyPersistence;

    public BookmarkService()
    {
        _dummyPersistence = new List<Bookmark> {
            new Bookmark { Guid="4581ef7e-c70e-441f-9d6a-a8432e1256dd", Title="Google", Url="https://google.com", Description="The Mighty Göøgle"},
            new Bookmark { Guid="698a6201-3c9c-4367-a65b-ca3a6ea6b416", Title="Microsoft", Url="https://microsoft.com", Description="The Good Ol´ M$"},
            new Bookmark { Guid="a7f169e5-5f97-41c5-8461-cf0a9621151b", Title="ANUG", Url="https://anug.dk", Description="Aarhus .Net User Group"},
        };
    }

    public async Task<List<Bookmark>> GetBookmarks()
    {
        await Task.CompletedTask;
        return _dummyPersistence;
    }
    public async Task AddBookmark(Bookmark bookmark)
    {
        await Task.CompletedTask;
        _dummyPersistence.Add(bookmark);
    }

    public async Task UpdateBookmark(Bookmark updatedBookmark)
    {
        await Task.CompletedTask;
        var existingBookmark = _dummyPersistence.FirstOrDefault(b => b.Guid == updatedBookmark.Guid);
        if (existingBookmark != null)
        {
            existingBookmark.Title = updatedBookmark.Title;
            existingBookmark.Url = updatedBookmark.Url;
            existingBookmark.Description = updatedBookmark.Description;
        }
        else { 
            await AddBookmark(updatedBookmark);
        }
    }

    //public Task DeleteBookmark(string bookmarkGuid)
    //{
    //    throw new NotImplementedException();
    //}

    public async Task<Bookmark> GetBookmark(string bookmarkGuid)
    {
        return (await GetBookmarks()).FirstOrDefault(b => b.Guid == bookmarkGuid) ?? new Bookmark { Guid = bookmarkGuid };
    }
}
