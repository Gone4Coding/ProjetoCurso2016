
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PrototipoFuncionalClubeDeJudoDragao
{

using System;
    using System.Collections.Generic;
    
public partial class Socios
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Socios()
    {

        this.Inscricao = new HashSet<Inscricao>();

        this.Quotas = new HashSet<Quotas>();

    }


    public int NumeroSocio { get; set; }

    public string Morada { get; set; }

    public string CodigoPostal { get; set; }

    public string Localidade { get; set; }

    public System.DateTime DataNascimento { get; set; }

    public int Nif { get; set; }

    public int NumeroCC { get; set; }

    public System.DateTime DataEmissaoCC { get; set; }

    public string Nacionalidade { get; set; }

    public string Profissao { get; set; }

    public string Freguesia { get; set; }

    public string Concelho { get; set; }

    public string Sexo { get; set; }

    public string EstadoCivil { get; set; }

    public string Pai { get; set; }

    public string Mae { get; set; }

    public string Telefone1 { get; set; }

    public string Telefone2 { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Inscricao> Inscricao { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Quotas> Quotas { get; set; }

}

}
