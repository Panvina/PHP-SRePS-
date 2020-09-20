using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using PHP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PHPTest
{
	[TestClass]
	public class AddSalesTests
	{
		private static readonly string databaseLocation = @"C:\Users\aetha\Documents\SWE30010\PHP-SREPS\PHPdb.mdf";
		private static readonly string userName = @"(LocalDB)\MSSQLLocalDB";

		private static string conString = @"Data Source=" + userName + ";AttachDbFilename=" + databaseLocation + ";Integrated Security=True";
		private static SqlConnection con;

		private AddSales _as;

		[TestInitialize]
		public void SetUp()
		{
			_as = new AddSales();
		}

		[TestMethod]
		public void TestConnection()
		{
			con = new SqlConnection(conString);

			con.Open();
			Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
			con.Close();
		}

		[TestMethod]
		public void ValidateQuantityTest_Negative()
		{
			Assert.IsFalse(_as.ValidateQuantity("-5"));
			Assert.IsFalse(_as.ValidateQuantity("-1"));
			Assert.IsFalse(_as.ValidateQuantity("-0.1"));
			Assert.IsFalse(_as.ValidateQuantity("0"));
		}

		[TestMethod]
		public void ValidateQuantityTest_Valid()
		{
			Assert.IsTrue(_as.ValidateQuantity("1"));
			Assert.IsTrue(_as.ValidateQuantity("5"));
			Assert.IsTrue(_as.ValidateQuantity("1000"));
		}

		[TestMethod]
		public void ValidateQuantityTest_NaN()
		{
			Assert.IsFalse(_as.ValidateQuantity("false"));
			Assert.IsFalse(_as.ValidateQuantity("hi"));
			Assert.IsFalse(_as.ValidateQuantity("2020-01-20"));
			Assert.IsFalse(_as.ValidateQuantity("!.0"));
		}

		[TestMethod]
		public void ValidateDateTest_Valid()
		{
			Assert.IsTrue(_as.ValidateDate("2020-09-15"));
			Assert.IsTrue(_as.ValidateDate("2020-02-29"));
			Assert.IsTrue(_as.ValidateDate("2019-02-28"));
		}

		public void ValidateDateTest_OutOfRange()
		{
			Assert.IsFalse(_as.ValidateDate("1752-12-31"));
			Assert.IsFalse(_as.ValidateDate("10000-01-01"));
			Assert.IsFalse(_as.ValidateDate("2000-02-30"));
			Assert.IsFalse(_as.ValidateDate("2001-02-29"));
		}

		public void ValidateDateTest_NotADate()
		{
			Assert.IsFalse(_as.ValidateDate("0"));
			Assert.IsFalse(_as.ValidateDate("50"));
			Assert.IsFalse(_as.ValidateDate("Hi"));
			Assert.IsFalse(_as.ValidateDate(""));
		}

		[TestMethod]
		public void AddSale()
		{ 
			con = new SqlConnection(conString);

			con.Open();

			string prodID = "50";
			int quantity = 49;
			string date = ("2000-01-02");

			string query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quantity}, '{date}')";

			SqlCommand cmd = new SqlCommand(query, con);
			Assert.AreEqual(1, cmd.ExecuteNonQuery());

			query = "DELETE FROM Sales WHERE DATE='2000-01-02'";
			cmd = new SqlCommand(query, con);
			Assert.AreEqual(1, cmd.ExecuteNonQuery());

			con.Close();
		}
	}
}
