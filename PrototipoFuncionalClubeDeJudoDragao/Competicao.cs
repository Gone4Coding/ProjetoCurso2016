
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
    
public partial class Competicao
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Competicao()
    {

        this.ResultadoCompeticao = new HashSet<ResultadoCompeticao>();

    }


    public int IdCompeticao { get; set; }

    public string Localidade { get; set; }

    public string Descricao { get; set; }

    public System.DateTime Data { get; set; }

    public string Categoria { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ResultadoCompeticao> ResultadoCompeticao { get; set; }

    public virtual Nivel Nivel { get; set; }

}

}
