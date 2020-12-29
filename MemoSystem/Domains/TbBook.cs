using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbBook
    {
        public TbBook()
        {
            TbAuthourBooks = new HashSet<TbAuthourBook>();
            TbBookGenres = new HashSet<TbBookGenre>();
            TbBookLanguages = new HashSet<TbBookLanguage>();
            TbBookTopics = new HashSet<TbBookTopic>();
            TbPosts = new HashSet<TbPost>();
            TbPublisherBooks = new HashSet<TbPublisherBook>();
            TbRates = new HashSet<TbRate>();
            TbReaderBooks = new HashSet<TbReaderBook>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ImageName { get; set; }
        public string BookIsbn { get; set; }
        public string Edition { get; set; }
        public string Summary { get; set; }
        public int Length { get; set; }
        public int FormatId { get; set; }
        public int? TimePeriod { get; set; }

        public virtual TbFormat Format { get; set; }
        public virtual ICollection<TbAuthourBook> TbAuthourBooks { get; set; }
        public virtual ICollection<TbBookGenre> TbBookGenres { get; set; }
        public virtual ICollection<TbBookLanguage> TbBookLanguages { get; set; }
        public virtual ICollection<TbBookTopic> TbBookTopics { get; set; }
        public virtual ICollection<TbPost> TbPosts { get; set; }
        public virtual ICollection<TbPublisherBook> TbPublisherBooks { get; set; }
        public virtual ICollection<TbRate> TbRates { get; set; }
        public virtual ICollection<TbReaderBook> TbReaderBooks { get; set; }
    }
}
