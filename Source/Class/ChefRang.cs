
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ChefRang : PersonnelCuisine
{

    public ChefRang(String Nom, String Prenom) : base(Nom, Prenom)
    {
        Rang = null;
    }

    //private String Nom;

    //private String Prenom;

    private Rang Rang;

    /// <summary>
    /// Le CR place les clients
    /// 
    /// @param Table
    /// </summary>
    public void PlaceClient(Table Table, Clients Clients)
    {
        //MAJ table
        Table.SetNombrePersonnes(Clients.GetNBClients());
        Table.SetClients(Clients);

        //MAJ clients
        //APPELLE PREND commande
        this.PrendCommande(Table);

    }

    /// <summary>
    /// 
    /// </summary>
    public void SetRang(Rang Rang)
    {
        this.Rang = Rang;
    }

    /// <summary>
    /// 
    /// </summary>

    public Rang GetRang()
    {
        return this.Rang;
    }

    /// <summary>
    /// Le CR prend la commande d'une table
    /// 
    /// @param Table
    /// </summary>
    public void PrendCommande(Table Table)
    {
        Clients Cli = null;
        string[] Commande = null;

        Cli = Table.GetClients();
        Commande = Cli.GetCommandes();

        //recup commande
        //la transmet en cuisine
        //Apporte pain et eau
        if (Table.GetHasEau() == false)
        {
            Table.SetHasEau(true);
        }

        if (Table.GetHasPain() == false)
        {
            Table.SetHasPain(true);
        }



    }

}