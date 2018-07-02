using LibraryData.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ILibraryCardService
    {
        IEnumerable<LibraryCard> GetAll();
        LibraryCard Get(int id);
        void Add(LibraryCard newCard);
    }
}
