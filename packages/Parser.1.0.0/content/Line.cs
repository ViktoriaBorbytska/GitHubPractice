using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// Represents a line of source code.
	/// </summary>
	public class Line : IComparable, IEnumerable, IEquatable<Line> {
		/// <summary>
		/// Numerical position of the line.
		/// </summary>
		public Int32 Number { get; protected set; }
		/// <summary>
		/// A string representing the line.
		/// </summary>
		protected String Content;
		/// <summary>
		/// The current position in the line.
		/// </summary>
		/// <remarks>
		///	<para>Starts at -1, right before the first character.</para>
		/// </remarks>
		protected Int32 Index = -1;

		#region Constructors
		protected Line() { }
		public Line(Int32 number, String content) {
			Number = number;
			Content = content;
		}
		public Line(Int32 number, Char[] content) {
			Number = number;
			Content = content.ToString();
		}
		public Line(Line line) {
			Number = line.Number;
			Content = line.Content;
		}
		#endregion Constructors

		/// <summary>
		/// Returns a copy of this line converted to lowercase.
		/// </summary>
		/// <returns>A lowercase line.</returns>
		public virtual Line ToLower() {
			return new Line(Number, Content.ToLower());
		}
		/// <summary>
		/// Returns a copy of this line converted to uppercase.
		/// </summary>
		/// <returns>An uppercase line.</returns>
		public virtual Line ToUpper() {
			return new Line(Number, Content.ToUpper());
		}

		/// <summary>
		/// Trim all leading and trailing white-space from the line.
		/// </summary>
		/// <returns>A trimmed line.</returns>
		public virtual Line Trim() {
			return new Line(Number, Content.Trim());
		}
		/// <summary>
		/// Trim all leading and trailing occurences of a set of characters from the line.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Line Trim(params Char[] trimChars) {
			return new Line(Number, Content.Trim(trimChars));
		}
		/// <summary>
		/// Trim all trailing occurences of a set of characters from the line.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Line TrimEnd(params Char[] trimChars) {
			return new Line(Number, Content.TrimEnd(trimChars));
		}
		/// <summary>
		/// Trim all leading occurences of a set of characters from the line.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Line TrimStart(params Char[] trimChars) {
			return new Line(Number, Content.TrimStart(trimChars));
		}

		/// <summary>
		/// Gets the number of characters in the current Line.
		/// </summary>
		public Int32 Length {
			get { return Content.Length; }
		}

		public override string ToString() {
			return Content;
		}
		public override int GetHashCode() {
			return Content.GetHashCode();
		}

		#region Enumerator
		IEnumerator IEnumerable.GetEnumerator() {
			return (IEnumerator)GetEnumerator();
		}
		public LineEnumerator GetEnumerator() {
			return new LineEnumerator(Content);
		}
		#endregion

		#region Indexer
		public Char this[Int32 position] {
			get { return Content[position]; }
		}
		#endregion Indexer

		#region Operators
		public static Boolean operator ==(Line left, Line right) {
			return left.Equals(right);
		}
		public static Boolean operator !=(Line left, Line right) {
			return !left.Equals(right);
		}
		#endregion Operators

		#region IComparable
		public Int32 CompareTo(Object obj) {
			if (obj == null) return 1;

			Line line = obj as Line;
			if (line != null) return this.Number.CompareTo(line.Number);
			else throw new ArgumentException("Object is not a Line");
		}
		#endregion IComparable

		#region IEquatable
		public Boolean Equals(Line line) {
			if (this.Number == line.Number && this.Content == line.Content) return true;
			else return false;
		}
		public override Boolean Equals(Object obj) {
			Line line = obj as Line;
			if (line == null) return false;
			else return Equals(line);
		}
		#endregion IEquatable
	}
}
