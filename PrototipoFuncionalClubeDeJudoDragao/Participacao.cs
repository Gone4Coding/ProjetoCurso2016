
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
    
public partial class Participacao
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Participacao()
    {

        this.Inscricao = new HashSet<Inscricao>();

    }


    public int IdParticipacao { get; set; }

    public string Localidade { get; set; }

    public string Descricao { get; set; }

    public string Data { get; set; }



    public virtual Nivel Nivel { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Inscricao> Inscricao { get; set; }

}

}
