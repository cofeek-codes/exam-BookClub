//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookClub
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderProduct
    {
        public int idOrderProduct { get; set; }
        public int idProduct { get; set; }
        public int idOrder { get; set; }
        public int count { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}
