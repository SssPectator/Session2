//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo_exam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chief_experts
    {
        public int ID_CHIEF { get; set; }
        public string ФИО { get; set; }
        public string Сертификат { get; set; }
        public Nullable<int> exam_id { get; set; }
    
        public virtual Demo_exam Demo_exam { get; set; }
    }
}
