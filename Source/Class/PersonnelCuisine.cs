
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonnelCuisine {

    public PersonnelCuisine(String Nom , String Prenom) {
        this.Nom = Nom;
        this.Prenom = Prenom;
        IsBusy = false;
    }

    private String Nom;

    private String Prenom;

    private Boolean IsBusy;

    /// <summary>
    /// 
    /// </summary>
    
    public String GetNom() {
        return this.Nom;
    }

    /// <summary>
    /// 
    /// </summary>
    
    public String GetPrenom() {
        return this.Prenom;
    }

    /// <summary>
    /// 
    /// </summary>
 
    public Boolean GetIsBusy() {
        return this.IsBusy;
    }

    /// <summary>
    /// @param Boolean
    /// </summary>
    
    public void SetIsBusy(Boolean State) {
        this.IsBusy = State;
    }

}