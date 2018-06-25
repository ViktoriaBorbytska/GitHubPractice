using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	/// <summary>
	/// An enumerator for Source, which allows Line iteration in foreach loops.
	/// </summary>
	public class SourceEnumerator : IEnumerator {
		public List<Line> Lines = new List<Line>();

		Int32 Position = -1;

		public Boolean MoveNext() {
			Position++;
			return (Position < Lines.Count);
		}

		public void Reset() {
			Position = -1;
		}

		Object IEnumerator.Current {
			get { return Current; }
		}

		public Line Current {
			get {
				try {
					return Lines[Position];
				} catch (IndexOutOfRangeException) {
					throw new InvalidOperationException();
				}
			}
		}

		public SourceEnumerator(List<Line> lines) {
			foreach (Line l in Lines) { Lines.Add(l); }
		}
	}
}
