
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commande {

    public Commande(Table Table, String Plat) {
        this.Table = Table;
        this.Plat=Plat;
    }

    private Table Table;

    private String Plat;

    private Boolean EnCours;

    public Table GetTable() {
        return this.Table;
    }

    public string GetPlats() {
        return this.Plat;
    }

    /// <summary>
    /// @param Plat
    /// </summary>
    public void SetPlats(string Plat) {
        this.Plat = Plat;
    }

}