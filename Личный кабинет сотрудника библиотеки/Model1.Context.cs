﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Личный_кабинет_сотрудника_библиотеки
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class БиблиотекаEntities3 : DbContext
    {
        public БиблиотекаEntities3()
            : base("name=БиблиотекаEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookSet> BookSet { get; set; }
        public virtual DbSet<DealSet> DealSet { get; set; }
        public virtual DbSet<ReaderSet> ReaderSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
