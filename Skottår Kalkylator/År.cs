namespace Skottår_Kalkylator
{
	public class År
	{
		public static bool ÄrSkottår(int år)
		{
			bool delbartMed400 = år % 400 == 0;

			bool delbartMed100MenInteMed400 = år % 100 == 0 && år % 400 != 0 && år % 100 != 0;

			bool delbartMed4MenInteMed100 = år % 4 == 0 && år % 100 != 0;

			bool inteÄrDelbartMed4 = år % 4 != 0;

			Console.WriteLine($"År: {år}, Delbart med 400: {delbartMed400}, Delbart med 100 men inte med 400: {delbartMed100MenInteMed400}, Delbart med 4 men inte med 100: {delbartMed4MenInteMed100}, Inte delbart med 4: {inteÄrDelbartMed4}");


			return delbartMed400 || delbartMed100MenInteMed400 || delbartMed4MenInteMed100 || inteÄrDelbartMed4;

			//throw new NotImplementedException();
		}

	}
}