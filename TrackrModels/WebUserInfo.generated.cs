#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace TrackrModels	
{
	[System.Serializable()]
	public partial class WebUserInfo : System.Runtime.Serialization.ISerializable
	{
		private int _userID;
		public virtual int UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				this._userID = value;
			}
		}
		
		private string _fName;
		public virtual string FName
		{
			get
			{
				return this._fName;
			}
			set
			{
				this._fName = value;
			}
		}
		
		private System.Nullable<System.Char> _mInitial;
		public virtual System.Nullable<System.Char> MInitial
		{
			get
			{
				return this._mInitial;
			}
			set
			{
				this._mInitial = value;
			}
		}
		
		private string _lName;
		public virtual string LName
		{
			get
			{
				return this._lName;
			}
			set
			{
				this._lName = value;
			}
		}
		
		#region ISerializable Implementation
		
		public WebUserInfo()
		{
		}
		
		protected WebUserInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.UserID = info.GetInt32("UserID");
			this.FName = info.GetString("FName");
			this.MInitial = (System.Nullable<System.Char>)info.GetValue("MInitial", typeof(System.Nullable<System.Char>));
			this.LName = info.GetString("LName");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("UserID", this.UserID, typeof(int));
			info.AddValue("FName", this.FName, typeof(string));
			info.AddValue("MInitial", this.MInitial, typeof(System.Nullable<System.Char>));
			info.AddValue("LName", this.LName, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
