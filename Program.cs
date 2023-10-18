namespace MiApp2
{
	public class Program
	{

		static void Main()
		{
			int VocalesGuardadas = 0;
			int Equivocaciones = 0;
			string[] VocalesInsertadas = new string[5] { "-", "-", "-", "-", "-" };

			Console.WriteLine("\tPrograma que ofende :_|_: [ HP ]\n");

			while (true)
			{
				if (VocalesGuardadas != 5)
				{

					VocalesIngresadas(VocalesInsertadas);
					Console.Write("\nINGRESA UNA pvta VOCAL Faltante (-): ");
					ConsoleKey press = Console.ReadKey().Key;

					if (press == ConsoleKey.A)
					{
						if (VocalesInsertadas[0] != press.ToString())
						{
							VocalesInsertadas[0] = press.ToString();
							Console.WriteLine("\n Sigue así, sabandija.");
							VocalesGuardadas++;
						}
						else
						{
							Equivocaciones++;
							Console.WriteLine("\n Cabeza de cucaracha, ya tu has introducido la VOCAL: {0}", press);
						}
					}
					else if (press == ConsoleKey.E)
					{
						if (VocalesInsertadas[1] != press.ToString())
						{
							VocalesInsertadas[1] = press.ToString();
							Console.WriteLine("\n Sigue así, sabandija.");
							VocalesGuardadas++;
						}
						else
						{
							Equivocaciones++;

							Console.WriteLine("\n Cabeza de cucaracha, ya tu has introducido la VOCAL: {0}", press);
						}
					}
					else if (press == ConsoleKey.I)
					{
						if (VocalesInsertadas[2] != press.ToString())
						{
							VocalesInsertadas[2] = press.ToString();
							Console.WriteLine("\n Sigue así, sabandija.");
							VocalesGuardadas++;
						}
						else
						{
							Equivocaciones++;

							Console.WriteLine("\n Cabeza de cucaracha, ya tu has introducido la VOCAL: {0}", press);
						}
					}
					else if (press == ConsoleKey.O)
					{
						if (VocalesInsertadas[3] != press.ToString())
						{
							VocalesInsertadas[3] = press.ToString();
							Console.WriteLine("\n Sigue así, sabandija.");
							VocalesGuardadas++;
						}
						else
						{
							Equivocaciones++;

							Console.WriteLine("\n Cabeza de cucaracha, ya tu has introducido la VOCAL: {0}", press);
						}
					}
					else if (press == ConsoleKey.U)
					{
						if (VocalesInsertadas[4] != press.ToString())
						{
							VocalesInsertadas[4] = press.ToString();
							Console.WriteLine("\n Bien hecho. Sigue así, sabandija.");
							VocalesGuardadas++;
						}
						else
						{
							Equivocaciones++;

							Console.WriteLine("\n Cabeza de cucaracha, ya tu has introducido la VOCAL: {0}", press);
						}
					}
					else
					{
						Console.WriteLine("\nSabandija, Ingresa una de las vocales faltantes. HP");
						Equivocaciones++;
					}
				}
				else
				{
					break;
				}
			}

			VocalesIngresadas(VocalesInsertadas);

			if (Equivocaciones > 0)
			{
				Console.WriteLine("Lo lograste, aunque tuviste {0} equivocaciones por salvaje.", Equivocaciones);
			}
			else
			{
				Console.WriteLine("\n Lo Lograste BICHO \nBIEN HECHO CULERO :). Lo lograste sin equivocarte, grande HP.");
			}
			Console.ReadKey();
		}
		static void VocalesIngresadas(string[] v)
		{
			Console.WriteLine($"\n{v[0]} {v[1]} {v[2]} {v[3]} {v[4]} ");
		}
	}

}


