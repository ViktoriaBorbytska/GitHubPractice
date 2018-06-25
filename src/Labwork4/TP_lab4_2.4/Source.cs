using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// Represents a source file.
	/// </summary>
	/// <remarks>
	/// <para>Effectively, this is a buffer of the source file. Manipulations of Source occur to this buffer, not the file directly.</para>
	/// </remarks>
	public class Source : IEnumerable {
		/// <summary>
		/// Represents all lines in the source.
		/// </summary>
		protected List<Line> Lines = new List<Line>();
		/// <summary>
		/// If Source was actually read from a file, this points to that file. Null otherwise.
		/// </summary>
		private readonly String Path = null;

		#region Constructors
		protected Source() { }
		public Source(String path) {
			String line;
			Int32 index = 0;
			using (StreamReader file = new StreamReader(path)) {
				while ((line = file.ReadLine()) != null) {
					Lines.Add(new Line(index, line));
					index++;
				}
			}
			Path = path;
		}
		public Source(List<Line> lines) {
			foreach (Line l in Lines) { Lines.Add(l); }
		}
		#endregion Constructors

		/// <summary>
		/// Gets the number of lines in the current source.
		/// </summary>
		public Int32 Count {
			get { return Lines.Count; }
		}

		#region Enumerator
		IEnumerator IEnumerable.GetEnumerator() {
			return (IEnumerator)GetEnumerator();
		}
		public SourceEnumerator GetEnumerator() {
			return new SourceEnumerator(Lines);
		}
		#endregion Enumerator

		#region Indexer
		/// <summary>
		/// Indexer for the source file, representing the internal lines.
		/// </summary>
		/// <param name="lineNumber">The number of the line.</param>
		/// <returns>The specified line.</returns>
		public Line this[Int32 lineNumber] {
			get { return Lines[lineNumber]; }
		}
		#endregion Indexer
	}
}
