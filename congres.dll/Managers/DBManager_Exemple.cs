using System.Data.SqlClient;

namespace congres.dll
{
	/// <summary>
	/// Classe de connexion � la base de donn�e.
	/// </summary>
	public static class DBManager
	{
		//METTRE LES INFORMATIONS DE CONNEXION ICI
		static private string dataSource = "METTRE NOM DU PC ICI";
		static private string login = "AppliGestCongres";
		static private string password = "MdpComplexe34";
		static public SqlConnection ConnexionDB = new SqlConnection($"Data Source={DBManager.dataSource};Initial Catalog=CongresDB;Integrated Security=True;user Id={DBManager.login};password={DBManager.password}");
	}
}