using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// Represents a token of source code.
	/// </summary>
	public class Token : IComparable, IEnumerable, IEquatable<Token> {
		/// <summary>
		/// A string representing the token.
		/// </summary>
		protected String Content;

		#region Constructors
		protected Token() { }
		public Token(String content) {
			Content = content;
		}
		public Token(Char[] content) {
			Content = content.ToString();
		}
		public Token(Token token) {
			Content = token.Content;
		}
		#endregion Constructors

		/// <summary>
		/// Returns a copy of the token converted to lowercase.
		/// </summary>
		/// <returns>A lowercase token.</returns>
		public virtual Token ToLower() {
			return new Token(Content.ToLower());
		}
		/// <summary>
		/// Returns a copy of the token converted to uppercase.
		/// </summary>
		/// <returns>An uppercase token.</returns>
		public virtual Token ToUpper() {
			return new Token(Content.ToUpper());
		}

		/// <summary>
		/// Trim all leading and trailing white-space from the token.
		/// </summary>
		/// <returns>A trimmed token.</returns>
		public virtual Token Trim() {
			return new Token(Content.Trim());
		}
		/// <summary>
		/// Trim all leading and trailing occurences of a set of characters from the token.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Token Trim(params Char[] trimChars) {
			return new Token(Content.Trim(trimChars));
		}
		/// <summary>
		/// Trim all trailing occurences of a set of characters from the token.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Token TrimEnd(params Char[] trimChars) {
			return new Token(Content.TrimEnd(trimChars));
		}
		/// <summary>
		/// Trim all leading occurences of a set of characters from the token.
		/// </summary>
		/// <param name="trimChars">Any unicode characters to remove, or null.</param>
		/// <returns></returns>
		public virtual Token TrimStart(params Char[] trimChars) {
			return new Token(Content.TrimStart(trimChars));
		}

		/// <summary>
		/// Gets the number of characters in the current Token.
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
		public TokenEnumerator GetEnumerator() {
			return new TokenEnumerator(Content);
		}
		#endregion Enumerator

		#region Indexer
		public Char this[Int32 position] {
			get { return Content[position]; }
		}
		#endregion

		#region Operators
		public static Boolean operator ==(Token left, Token right) {
			return left.Equals(right);
		}
		public static Boolean operator !=(Token left, Token right) {
			return !left.Equals(right);
		}
		#endregion

		#region IComparable
		public Int32 CompareTo(Object obj) {
			if (obj == null) return 1;

			Token token = obj as Token;
			if (token != null) return this.Content.CompareTo(token.Content);
			else throw new ArgumentException("Object is not a Token");
		}
		#endregion IComparable

		#region IEquatable
		public Boolean Equals(Token token) {
			if (this.Content == token.Content) return true;
			else return false;
		}
		public override Boolean Equals(Object obj) {
			Token token = obj as Token;
			if (token == null) return false;
			else return Equals(token);
		}
		#endregion
	}
}
