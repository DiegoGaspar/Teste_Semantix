﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste_Semantix
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TesteSemantixEntities : DbContext
    {
        public TesteSemantixEntities()
            : base("name=TesteSemantixEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cliente_Endereco> Cliente_Endereco { get; set; }
        public DbSet<Cliente_Telefone> Cliente_Telefone { get; set; }
    }
}
