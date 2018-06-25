using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// An enumerator for Token, which allows Char iteration in foreach loops.
	/// </summary>
	public class TokenEnumerator : IEnumerator {
		public String Content;

		Int32 Position = -1;

		public Boolean MoveNext() {
			Position++;
			return (Position < Content.Length);
		}

		public void Reset() {
			Position = -1;
		}

		Object IEnumerator.Current {
			get { return Current; }
		}

		public Char Current {
			get {
				try {
					return Content[Position];
				} catch (IndexOutOfRangeException) {
					throw new InvalidOperationException();
				}
			}
		}

		public TokenEnumerator(String content) {
			Content = content;
		}
	}
}
