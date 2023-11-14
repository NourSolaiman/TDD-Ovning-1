namespace Skottår_Kalkylator
{
	public class År
	{
		public static bool ÄrSkottår(int år)
		{
			bool delbartMed400 = år % 400 == 0;

			bool delbartMed100MenInteMed400 = år % 100 == 0 && år % 400 != 0 && år % 100 != 0;

			return delbartMed400 || delbartMed100MenInteMed400;

			//throw new NotImplementedException();
		}

	}
}