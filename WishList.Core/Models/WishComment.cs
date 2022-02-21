using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishList.Core.Models
{
    /// <summary>Comments/ messages about item </summary>
    public class WishComment
    {
        /// <summary>Row Id</summary>
        public int Id { get; set; }

        /// <summary>Wishlist item</summary>
        public int WishId { get; set; }

        /// <summary>Who can see the comment</summary>
        public VisibleTo VisibleTo { get; set; }

        /// <summary>Who made the comment</summary>
        public string UserId { get; set; }

        /// <summary>Date comment was created</summary>
        public DateTime? Created { get; set; }=DateTime.Now;

        /// <summary>Comment text</summary>
        public string Comment { get; set; }

        /// <summary>Links back to the wishlist item</summary>
        public Wish Wish { get; set; }

        
    }
}
