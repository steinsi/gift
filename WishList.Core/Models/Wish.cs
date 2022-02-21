using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishList.Core.Models
{
    /// <summary>
    /// Wish List Item
    /// </summary>
    public class Wish
    {
        /// <summary>Database row Id</summary>
        public int Id { get; set; }
         
        /// <summary>User Id of who's wish it is</summary>
        public string UserId { get; set; }

        /// <summary>Title of the Gift Ex: "Jet Ski"</summary>
        public string Title { get; set; }

        /// <summary>Cost in dollars</summary>
        public decimal Price { get; set; }

        /// <summary>Any further info</summary>
        public string Notes { get; set; }

        /// <summary>Where to buy</summary>
        public string Store { get; set; }

        /// <summary>Link to item</summary>
        public Uri Link { get; set; }
        
        /// <summary>Who bought the item</summary>
        public string PurchasedByUserId { get; set; }

        public DateTime Created { get; set; }

        /// <summary>All comments for this wish item</summary>
        public List<WishComment> Comments { get; set; }

        public Wish()
        {
            Comments = new List<WishComment>();
        }
    }
}
