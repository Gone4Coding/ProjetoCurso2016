
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
    
public partial class Exame
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Exame()
    {

        this.Inscricao = new HashSet<Inscricao>();

    }


    public int IdExame { get; set; }

    public System.DateTime Data { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Inscricao> Inscricao { get; set; }

    public virtual Graduacao Graduacao { get; set; }

}

}
