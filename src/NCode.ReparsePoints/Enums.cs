﻿using System;

namespace NCode.ReparsePoints
{
	/// <summary>
	/// Represents the type of reparse point such as a hard link, junction (aka
	/// soft link), or symbolic link.
	/// </summary>
	[Serializable]
	public enum LinkType
	{
		/// <summary>
		/// Represents an unknown reparse point type.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Represents a file <c>hard link</c>.
		/// </summary>
		/// <remarks>
		/// Technically not a reparse point.
		/// </remarks>
		HardLink,

		/// <summary>
		/// Represents a directory <c>junction</c> (aka soft link).
		/// </summary>
		Junction,

		/// <summary>
		/// Represents a <c>symbolic link</c> to either a file or folder.
		/// </summary>
		/// <remarks>
		/// In order to create symbolic links, the current user must either be an
		/// administrator running with elevated privileges or a non-admin user that
		/// has the SeCreateSymbolicLinkPrivilege right in local security policy.
		/// </remarks>
		Symbolic
	}
}