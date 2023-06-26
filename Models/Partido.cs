class Partido{
    int IdPartido{get;set;}
    string Nombre{get;set;}
    string Logo{get;set;}
    string SitioWeb{get;set;}
    DateTime FechaFundacion{get;set;}
    int CantidadDiputados{get;set;}
    int CantidadSenadores{get;set;}
}

class Candidato{
    int IdCandidato{get;set;}
    int IdPartido{get;set;}
    string Apellido{get;set;}
    string Nombre{get;set;}
    DateTime FechaNaciemiento{get;set;}
    string Foto{get;set;}
    string Postulacion{get;set;}
}

static class BD{
    public static void AgregarCantidato(Candidato can){

    }
    public static void EliminarCandidato(int idCandidato){

    }
    public static Partido VerInfoPartido(int IdPartido){
        
    }
    public static Candidato VerInfoCandidato(int idCandidato){

    }
    public static List<Partido> ListarPartidos(){

    }
    public static List<Candidato> ListarCandidatos(int IdPartido){

    }
}

