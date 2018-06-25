using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// An abstract enumerator for ParseTree, which allows iterations in foreach loops.
	/// </summary>
	public abstract class ParseTreeEnumerator : IEnumerator {
		public abstract Boolean MoveNext();
		public abstract void Reset();
		Object IEnumerator.Current { get { return Current; } }
		public abstract Token Current { get; }
	}
}