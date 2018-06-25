using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// Represents a basic abstract parser. This must be extended to actually parse something.
	/// </summary>
	public abstract class Parser {
		/// <summary>
		/// Source file currently being parsed.
		/// </summary>
		public Source Source { get; protected set; }

		#region Constructors
		protected Parser() { }
		public Parser(String path) {
			Source = new Source(path);
		}
		#endregion Constructors

		/// <summary>
		/// Parse the source, building a ParseTree.
		/// </summary>
		/// <returns>The parse-tree representing the Source.</returns>
		public abstract ParseTree Parse();
	}
}
