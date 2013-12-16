﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ContactType'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ContactType : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ContactType"/> class.</summary>
		public ContactType() : base()
		{
			this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ContactTypeId field. </summary>
		[DataMember]
		public System.Int32 ContactTypeId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntityContact.ContactType - ContactType.BusinessEntityContacts (m:1)'</summary>
		[DataMember]
		public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set;}
		#endregion
	}
}