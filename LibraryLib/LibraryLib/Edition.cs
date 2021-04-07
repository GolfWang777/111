using System;

namespace LibraryLib
{
    public class Edition
    {
        public string Title;
        public string ListOfAuthors;
        public int YearPublished;
        public string Publisher;
        public readonly long UniqueID;
        public Location WhereBook;

        public Edition(string title, string listOfAuthors, int yearPublished, string publisher, long uniqueID, Location whereBook)
        {
            Title = title;
            ListOfAuthors = listOfAuthors;
            YearPublished = yearPublished;
            Publisher = publisher;
            UniqueID = uniqueID;
            WhereBook = whereBook;
        }
        public override string ToString()
        {
            return $"Книга: {Title}. Автор(ы): {ListOfAuthors}.";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var whereBook = "";
            switch (WhereBook)
            {
                case Location.Home:
                    whereBook = "выдана на дом";
                    break;
                case Location.ReadingRoom:
                    whereBook = "выдана в читательный зал";
                    break;
                case Location.Storage:
                    whereBook = "в хранилище";
                    break;
            }
           
            Console.WriteLine($"Год издания: {YearPublished}. Издатель: {Publisher}. Инвентарный номер: {UniqueID}. Статус: {whereBook}.");
        }
    }
}
