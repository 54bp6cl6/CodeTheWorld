using System.Collections.Generic;

namespace CodeTheWorld.Genesis
{
	/// <summary>
	/// 極初之時，一切皆無，
	/// 而祂以道為筆，神為墨，
	/// 揮灑六句，宇宙既成。
	/// </summary>
	public static class Universe
	{
		/// <summary>宇為空，宙為時，萬物生衍其間。</summary>
		public static List<object> Inside { get; set; }
		
		static Universe()
		{
			Inside = new List<object>();
		}

		/// <summary>
		/// 山河崩，天地變。那人說道一句：「好咧！」一切盡滅。
		/// </summary>
		public static void TheApocalypse()
		{
			Inside.Clear();
			Inside = null;
		}
	}
}
