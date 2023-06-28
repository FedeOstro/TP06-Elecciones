using System.Data.SqlClient;
using Dapper; 

static class BD{
    private static string _connectionString = @"A-PHZ2-CIDI-052=localhost;Elecciones2023=NombreBase;Trusted_Connection=True;";
    public static void AgregarCantidato(Candidato can){
        string SQL = "INSERT INTO Candidato(IdCandidato, IdPartido, Apellido, Nombre, FechaNacimiento, Foto, Postulacion) VALUES (@cIdCandidato, @cIdPartido, @cApellido, @cNombre, @cFechaNacimiento, @cFoto, @cPostulacion)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(SQL, new{cIdCandidato = can.IdCandidato, cIdPartido = can.IdPartido, cApellido = can.Apellido, cNombre = can.Nombre, cFechaNacimiento= can.FechaNacimiento, cFoto = can.Foto, cPostulacion = can.Postulacion});
        }
    }
    public static void EliminarCandidato(int IdCandidato){
        string SQL = "DELETE FROM Candidato WHERE IdCandidato = @cIdCandidato";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new{cIdCandidato = IdCandidato});
        }
    }
    public static Partido VerInfoPartido(int IdPartido){
       Partido miPartido = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string SQL = "SELECT * FROM Partido WHERE IdPartido = @cIdPartido";

            miPartido = db.QueryFirstOrDefault<Partido>(SQL, new{cIdPartido = IdPartido});
        }
        return miPartido;
    }
    public static Candidato VerInfoCandidato(int idCandidato){
        Candidato miCandidato = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string SQL = "SELECT * FROM Candidato WHERE IdCandidato = @cIdCandidato";

            miCandidato = db.QueryFirstOrDefault<Candidato>(SQL, new{cICandidato = idCandidato});
        }
        return miCandidato;
    }
    private static List<Partido> _ListoPartido = new List<Partido>();
    public static List<Partido> ListarPartidos(){
         using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT *  FROM Partido ";
            _ListaPartido = db.Query<Partido>(sql, new{}).ToList();
         }
        return _ListaPartido;
    }
    public static List<Candidato> ListarCandidatos(int IdPartido){

    }
}