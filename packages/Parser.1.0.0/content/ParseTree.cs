using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// Represents an abstract parse-tree; the output of parser.
	/// </summary>
	public abstract class ParseTree : IEnumerable {
		#region Enumerator
		IEnumerator IEnumerable.GetEnumerator() {
			return (IEnumerator)GetEnumerator();
		}
		public abstract ParseTreeEnumerator GetEnumerator();
		#endregion Enumerator
	}
}
