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
using TrackrModels;

namespace TrackrModels	
{
	[System.Serializable()]
	public partial class EmailAddress : System.Runtime.Serialization.ISerializable
	{
		private int _emailAddressID;
		public virtual int EmailAddressID
		{
			get
			{
				return this._emailAddressID;
			}
			set
			{
				this._emailAddressID = value;
			}
		}
		
		private bool _isHTML;
		public virtual bool IsHTML
		{
			get
			{
				return this._isHTML;
			}
			set
			{
				this._isHTML = value;
			}
		}
		
		private int _personID;
		public virtual int PersonID
		{
			get
			{
				return this._personID;
			}
			set
			{
				this._personID = value;
			}
		}
		
		private byte _sortOrder;
		public virtual byte SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				this._sortOrder = value;
			}
		}
		
		private string _email;
		public virtual string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		
		private int _lastModifiedBy;
		public virtual int LastModifiedBy
		{
			get
			{
				return this._lastModifiedBy;
			}
			set
			{
				this._lastModifiedBy = value;
			}
		}
		
		private DateTime _lastModifiedAt;
		public virtual DateTime LastModifiedAt
		{
			get
			{
				return this._lastModifiedAt;
			}
			set
			{
				this._lastModifiedAt = value;
			}
		}
		
		private bool _active;
		public virtual bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		
		private Person _person;
		public virtual Person Person
		{
			get
			{
				return this._person;
			}
			set
			{
				this._person = value;
			}
		}
		
		#region ISerializable Implementation
		
		public EmailAddress()
		{
		}
		
		protected EmailAddress(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.EmailAddressID = info.GetInt32("EmailAddressID");
			this.IsHTML = info.GetBoolean("IsHTML");
			this.PersonID = info.GetInt32("PersonID");
			this.SortOrder = info.GetByte("SortOrder");
			this.Email = info.GetString("Email");
			this.LastModifiedBy = info.GetInt32("LastModifiedBy");
			this.LastModifiedAt = (DateTime)info.GetValue("LastModifiedAt", typeof(DateTime));
			this.Active = info.GetBoolean("Active");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("EmailAddressID", this.EmailAddressID, typeof(int));
			info.AddValue("IsHTML", this.IsHTML, typeof(bool));
			info.AddValue("PersonID", this.PersonID, typeof(int));
			info.AddValue("SortOrder", this.SortOrder, typeof(byte));
			info.AddValue("Email", this.Email, typeof(string));
			info.AddValue("LastModifiedBy", this.LastModifiedBy, typeof(int));
			info.AddValue("LastModifiedAt", this.LastModifiedAt, typeof(DateTime));
			info.AddValue("Active", this.Active, typeof(bool));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
