//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooWorld_Larin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int order_id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public System.DateTime date_o { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Products Products { get; set; }
    }
}
