//
//  EmptyEntries.cs
//
//  Author:
//       Pierrick Caillon <pierrick@megami.fr>
//
//  Copyright (c) 2011 Pierrick Caillon
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace zipdirfs
{
	class EmptyEntries : AbstractEntries
	{
		#region implemented abstract members of zipdirfs.AbstractEntries
		public override System.Collections.Generic.IEnumerator<Mono.Fuse.DirectoryEntry> GetEnumerator()
		{
			yield return MakeDirectoryEntry(".", writeTime, 0);
			yield return MakeDirectoryEntry("..", DateTime.Now, 0);
		}
		#endregion

		private DateTime writeTime;

		internal EmptyEntries(DateTime writeTime)
		{
			this.writeTime = writeTime;
		}
	}
}

