
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
    
public partial class entidades
{

    public int numero_entidade { get; set; }

    public string nome { get; set; }

    public string localidade { get; set; }

    public string codigo_postal { get; set; }

    public string contato { get; set; }

    public string tipo_entidade { get; set; }



    public virtual entidades_quotas entidades_quotas { get; set; }

}

}
