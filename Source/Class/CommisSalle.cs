
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class CommisSalle : PersonnelCuisine
{

    private CommisSalle(String Nom = "NOM", String Prenom = "PRENOM") : base(Nom, Prenom)
    {
    }

    private static CommisSalle instance = null;


    //private String Nom;

    //private String Prenom;

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>
    public static CommisSalle GetInstance(String Nom = null, String Prenom = null)
    {
        if (CommisSalle.instance == null)
        {
            CommisSalle.instance = new CommisSalle(Nom, Prenom);
        }
        return CommisSalle.instance;
    }


    /// <summary>
    /// Le commis amene l'eau
    /// </summary>

    public void AmenerEau(Table table)
    {
    }

    /// <summary>
    /// Le commis ammene du pain
    /// </summary>

    public void AmenerPain(Table table)
    {
    }

    /// <summary>
    /// Le commis redresse la table
    /// </summary>

    public void DresserTable(Table table)
    {
        //check si table debarrassé?
    }

}