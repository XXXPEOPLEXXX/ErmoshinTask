//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Importance { get; set; }
        public System.DateTime DeadLine { get; set; }
        public bool Completed { get; set; }
        public int IdUsersTable { get; set; }
    
        public virtual UsersTable UsersTable { get; set; }
    }
}
