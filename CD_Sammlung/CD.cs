using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Sammlung
{
	public class CD : IEquatable<CD>, IComparable<CD>
	{
		public readonly string Künstler;
		public readonly string Album;

		public CD(string k, string a)
		{
			if (string.IsNullOrEmpty(k)) throw new ArgumentException("Künstler darf nicht leer sein.");
			if (string.IsNullOrEmpty(a)) throw new ArgumentException("Album darf nicht leer sein.");

			Künstler = k;
			Album = a;
		}

		public int CompareTo(CD other)
		{
			return this.Album.CompareTo(other.Album);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as CD);
		}

		public bool Equals(CD other)
		{
			return other != null &&
						 Künstler == other.Künstler &&
						 Album == other.Album;
		}

		public override int GetHashCode()
		{
			int hashCode = -1695753542;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Künstler);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Album);
			return hashCode;
		}

		public override string ToString() => Album + " - " + Künstler;
	}
}
