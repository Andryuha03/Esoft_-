//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace esoft
{
    using System;
    using System.Collections.Generic;
    
    public partial class land_demands
    {
        public int Id { get; set; }
        public Nullable<int> IdDemands { get; set; }
        public Nullable<int> AgentId { get; set; }
        public Nullable<int> ClientId { get; set; }
    
        public virtual agent agent { get; set; }
        public virtual client client { get; set; }
        public virtual Demand Demand { get; set; }
    }
}
