using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic; 

public static class BD{
    private static string _connectionString = @"SERVER=localhost;DataBase=Elecciones2023;Trusted_Connection=True;";
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

    public static List<Partido> ListarPartidos(){
        List <Partido> ListaPartidos = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Partido";
            ListaPartidos = db.Query<Partido>(sql).ToList();
        }
        return ListaPartidos;
    }
    public static List<Candidato> ListarCandidatos(int IdPartido){
        List <Candidato> ListaCandidatos = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Candidato WHERE IdPartido = @cIdPartido";
            ListaCandidatos = db.Query<Candidato>(sql, new{cIdPartido = IdPartido}).ToList();
        }
        return ListaCandidatos;
    }
}