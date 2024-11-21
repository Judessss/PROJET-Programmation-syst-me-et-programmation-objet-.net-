
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rang {

    public Rang(Serveur Serveur, ChefRang ChefRang, Table[] ListeTables) {
        //initialisations par défauts
        this.Serveur = Serveur;
        this.ChefRang = ChefRang;
        this.ListeTables = ListeTables;
        Serveur.SetRang(this);
        ChefRang.SetRang(this);
    }

    private Serveur Serveur;

    private ChefRang ChefRang;

    private Table[] ListeTables;

    /// <summary>
    /// Renvoie le Serveur du rang, de type Serveur
    /// </summary>

    public Serveur GetServeur() {
        return this.Serveur;
    }

    /// <summary>
    /// Renvoie le Chef de Rang du Rang, de type ChefRang
    /// </summary>

    public ChefRang GetChefRang() {
        return this.ChefRang;
    }

    /// <summary>
    /// Renvoie la liste des tables du rang
    /// </summary>

    public Table[] GetListeTables() {
        return this.ListeTables;
    }

}