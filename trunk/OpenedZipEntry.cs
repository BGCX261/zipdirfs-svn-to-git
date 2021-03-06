//
//  OpenedZipEntry.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zipdirfs
{
	class OpenedZipEntry
	{
		public string Path
		{
			get;
			set;
		}
		public ICSharpCode.SharpZipLib.Zip.ZipEntry ZipEntry
		{
			get;
			set;
		}
		public System.IO.Stream Stream
		{
			get;
			set;
		}
		public long Position
		{
			get;
			set;
		}
		public byte[] Data
		{
			get;
			set;
		}
		public ZipFileReference ZipFile
		{
			get;
			set;
		}
		public DateTime LastAccess
		{
			get;
			set;
		}
		public int OpenCount
		{
			get;
			set;
		}

		public override string ToString()
		{
			return string.Format("{{ {0}:{1} Refs={3} {2}}}", Path, Position, LastAccess, OpenCount);
		}
	}
}
