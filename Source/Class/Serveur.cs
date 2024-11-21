
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Serveur : PersonnelCuisine
{

    public Serveur(String Nom, String Prenom) : base(Nom, Prenom)
    {
        Rang = null;
    }

    //private String Nom;

    //private String Prenom;

    private Rang Rang;

    public void SetRang(Rang Rang)
    {
        this.Rang = Rang;
    }

    public Rang GetRang()
    {
        return this.Rang;
    }

    /// <summary>
    /// Le Serveur debarasse
    /// </summary>

    public void Debarasse(Table table)
    {
        //Transmet aux presentoire salle un nb couvert proportionels a Table.NBpersonnes

    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public void AmenerSucre(Commande Commande)
    {
        // TODO implement here
    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public void AmenerSale(Commande Commande)
    {
        Table TableAServir = Commande.GetTable();
        Clients ClientsAServir = TableAServir.GetClients();
        ClientsAServir.SetServi(true);
        //Timer (gerer par winform)
    }

    /// <summary>
    /// @param Commande
    /// </summary>
    public int Addition()
    {
        return 10;
    }

}