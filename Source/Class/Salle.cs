
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//public class Salle : PresentoireSalle



    public class Salle {

    private Salle(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle) {
        this.CarreUn = CarreUn;
        this.CarreDeux = CarreDeux;
        this.MaitreHotel = MaitreHotel;
        this.Commis = Commis;
        this.PresentoireSalle = PresentoireSalle;
    }


    private static Salle instance = null;


    private Carre CarreUn;

    private Carre CarreDeux;

    private MaitreHotel MaitreHotel;

    private CommisSalle Commis;

    public DateTime Date;

    

    private PresentoireSalle PresentoireSalle;

    /// <summary>
    /// Renvoie l'attribut CarreUn de type Carre
    /// </summary>

    public Carre GetCarreUn() {
        return this.CarreUn;
    }

    /// <summary>
    /// Renvoie l'attribut CarreDeux de type Carre
    /// </summary>

    public Carre GetCarreDeux() {
        return this.CarreDeux;
    }

    /// <summary>
    /// Renvoie l'attribut MaitreHotel de MaitreHotel
    /// </summary>
    
    public MaitreHotel GetMaitreHotel() {
        return this.MaitreHotel;
    }

    /// <summary>
    /// Renvoie l'attribut Commis de type CommisSalle 
    /// </summary>

    public CommisSalle GetCommis() {
        return this.Commis;
    }

    /// <summary>
    /// Methode d'instanciation unique
    /// </summary>
    public static Salle GetInstance(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
    {
        if (Salle.instance == null)
        {
            // Arguments :
            //(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
            Salle.instance = new Salle(CarreUn, CarreDeux, MaitreHotel, Commis, PresentoireSalle);

        }
        return Salle.instance;
    }

    public void Service(Boolean Midi_Soir)
    {
        //false : MIDI ; true : SOIR

        //Regle l'heure

        //Genere les reservations

        //Genere les Clients OU 
        //Le programme va faire arriver les client

    }
}