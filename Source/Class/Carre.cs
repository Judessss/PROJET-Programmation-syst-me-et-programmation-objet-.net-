
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Carre {

    public Carre(Rang RangUn, Rang RangDeux) {
        this.RangUn = RangUn;
        this.RangDeux = RangDeux;
        //initialisations par defauts
    }

    private Rang RangUn;

    private Rang RangDeux;


    /// <summary>
    /// Renvoie l'attribut RangUn de type Rang
    /// </summary>

    public Rang GetRangUn() {
        return this.RangUn;
    }

    /// <summary>
    /// Renvoie l'attribut RangDeux de type Rang
    /// </summary>

    public Rang GetRangDeux() {
        return this.RangDeux;
    }

}