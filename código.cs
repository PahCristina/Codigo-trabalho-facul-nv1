using System;
using System.IO;

namespace StreamReadWrite
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(@"Escolha uma opção:
  1. Inventário de Software
  2. Inventário de Hardware
  3; Inventário de Software/hardware.");

			string inventario = Console.ReadLine();

			switch (inventario)		
	 		{
				case "1":
					StreamWriter arquivo1 = new StreamWriter(@"C:\temp\invsoft.bat", false);
					arquivo1.WriteLine("Get-CimInstance -Class Win32_Product");
					arquivo1.Close();  
					break;
				case "2":
					StreamWriter arquivo2 = new StreamWriter(@"C:\temp\invhard.bat", false);
					arquivo2.WriteLine("Get-ComputerInfo");
					arquivo2.Close();
					break;
				case "3":
					StreamWriter arquivo3 = new StreamWriter(@"C:\temp\invsofthard.bat", false);
					arquivo3.WriteLine("Get-CimInstance -Class Win32_Product");
					arquivo3.WriteLine("Get-ComputerInfo");
					arquivo3.Close();  
					break;
			}
		}
	}
}