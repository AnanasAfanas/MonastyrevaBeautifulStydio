//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonastyrevaBeautifulStydio.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uchet
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Detalspol { get; set; }
        public Nullable<int> IdSotrudnik { get; set; }
        public Nullable<int> IdMaterial { get; set; }
        public Nullable<decimal> Zena { get; set; }
        public Nullable<int> Kolvo { get; set; }
        public Nullable<decimal> Summa { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
