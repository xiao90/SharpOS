// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil;


namespace SharpOS.AOT.IR.Operands {
	/// <summary>
	/// 
	/// </summary>
	public class FloatConstant : Constant {
		/// <summary>
		/// Initializes a new instance of the <see cref="FloatConstant"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public FloatConstant (float value)
		{
			this.value = value;
			this.InternalType = InternalType.F;
		}

		private float value;

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public float Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString ()
		{
			return this.value.ToString ();
		}
	}
}