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
	public partial class Address : System.Runtime.Serialization.ISerializable
	{
		private int _addressID;
		public virtual int AddressID
		{
			get
			{
				return this._addressID;
			}
			set
			{
				this._addressID = value;
			}
		}
		
		private string _street1;
		public virtual string Street1
		{
			get
			{
				return this._street1;
			}
			set
			{
				this._street1 = value;
			}
		}
		
		private string _street2;
		public virtual string Street2
		{
			get
			{
				return this._street2;
			}
			set
			{
				this._street2 = value;
			}
		}
		
		private string _city;
		public virtual string City
		{
			get
			{
				return this._city;
			}
			set
			{
				this._city = value;
			}
		}
		
		private string _state;
		public virtual string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		
		private string _zipCode;
		public virtual string ZipCode
		{
			get
			{
				return this._zipCode;
			}
			set
			{
				this._zipCode = value;
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
		
		public Address()
		{
		}
		
		protected Address(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.AddressID = info.GetInt32("AddressID");
			this.Street1 = info.GetString("Street1");
			this.Street2 = info.GetString("Street2");
			this.City = info.GetString("City");
			this.State = info.GetString("State");
			this.ZipCode = info.GetString("ZipCode");
			this.PersonID = info.GetInt32("PersonID");
			this.SortOrder = info.GetByte("SortOrder");
			this.LastModifiedBy = info.GetInt32("LastModifiedBy");
			this.LastModifiedAt = (DateTime)info.GetValue("LastModifiedAt", typeof(DateTime));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("AddressID", this.AddressID, typeof(int));
			info.AddValue("Street1", this.Street1, typeof(string));
			info.AddValue("Street2", this.Street2, typeof(string));
			info.AddValue("City", this.City, typeof(string));
			info.AddValue("State", this.State, typeof(string));
			info.AddValue("ZipCode", this.ZipCode, typeof(string));
			info.AddValue("PersonID", this.PersonID, typeof(int));
			info.AddValue("SortOrder", this.SortOrder, typeof(byte));
			info.AddValue("LastModifiedBy", this.LastModifiedBy, typeof(int));
			info.AddValue("LastModifiedAt", this.LastModifiedAt, typeof(DateTime));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
