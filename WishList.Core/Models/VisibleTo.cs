using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishList.Core.Models
{        /// <summary>Visibility of comments</summary>
    public enum VisibleTo
    {
        /// <summary>Visible to everyone</summary>
        All,
        /// <summary>Private message to Wish item owner</summary>
        Owner,
        /// <summary>Visible to everyone but the owner</summary>
        NotOwner,

    }
}
